# XUTF

Все значения хранятся в формате **little endian**

---

## HEADER (17 байт)

```
fourCC сигнатура = "XUTF"
byte версия = 1
uint32 длина блока строк
uint32 длина блока узлов
uint32 длина блока данных
```

---

## VARINT ENCODING

Для обеспечения уникального битового представления каждого числа
каждый новый байт в varint-кодировании представляет:

> предыдущее минимальное значение + новое битовое кодирование

---

### Пример кодирования:

```csharp
if (u <= 127)
{
    PutByte((byte) u);
}
else if (u <= 16511)
{
    u -= 128;
    PutByte((byte) ((u & 0x7f) | 0x80));
    PutByte((byte) ((u >> 7) & 0x7f));
}
else if (u <= 2113662)
{
    u -= 16512;
    PutByte((byte) ((u & 0x7f) | 0x80));
    PutByte((byte) (((u >> 7) & 0x7f) | 0x80));
    PutByte((byte) ((u >> 14) & 0x7f));
}
else if (u <= 270549118)
{
    u -= 2113663;
    PutByte((byte) ((u & 0x7f) | 0x80));
    PutByte((byte) (((u >> 7) & 0x7f) | 0x80));
    PutByte((byte) (((u >> 14) & 0x7f) | 0x80));
    PutByte((byte) ((u >> 21) & 0x7f));
}
else
{
    u -= 270549119;
    PutByte((byte) ((u & 0x7f) | 0x80));
    PutByte((byte) (((u >> 7) & 0x7f) | 0x80));
    PutByte((byte) (((u >> 14) & 0x7f) | 0x80));
    PutByte((byte) (((u >> 21) & 0x7f) | 0x80));
    PutByte((byte) ((u >> 28) & 0x7f));
}
```

---

### Пример декодирования:

```csharp
int b = GetByte();
uint a = (uint) (b & 0x7f);
int extraCount = 0;

// первый дополнительный байт
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 7);
    extraCount++;
}

// второй
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 14);
    extraCount++;
}

// третий
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 21);
    extraCount++;
}

// четвёртый
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 28);
    extraCount++;
}

switch (extraCount)
{
    case 1:
        a += 128;
        break;
    case 2:
        a += 16512;
        break;
    case 3:
        a += 2113663;
        break;
    case 4:
        a += 270549119;
        break;
}
return a;
```

---

## STRING BLOCK

Располагается сразу после заголовка.

Блок строк UTF-8 с указанием длины (в байтах).
Весь блок сжат.

```
ushort длина
byte[length] utf8data
```

---

## NODE BLOCK

```
varint nameOffset — указывает на начало строки в string block
byte type — 0 для файла, 1 для директории
```

### type 0 (файл):

```
varint смещение данных — от начала data block
varint длина данных
```

### type 1 (директория):

```
varint количество узлов
node[node count] дочерние элементы
```

---

## DATA BLOCK

Располагается сразу после node block.

Представляет собой бинарный blob.
