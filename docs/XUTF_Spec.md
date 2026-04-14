# XUTF

All values are stored in **little endian** format

---

## HEADER (17 bytes)

```
fourCC signature = "XUTF"
byte version = 1
uint32 string block length
uint32 node block length
uint32 data block length
```

---

## VARINT ENCODING

To ensure a unique bit pattern for each integer,
each new byte in the varint encoding represents:

> the previous minimum value + the new bit encoding

---

### Encoding example:

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

### Decoding example:

```csharp
int b = GetByte();
uint a = (uint) (b & 0x7f);
int extraCount = 0;

// first extra byte
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 7);
    extraCount++;
}

// second
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 14);
    extraCount++;
}

// third
if ((b & 0x80) == 0x80)
{
    b = GetByte();
    a |= (uint) ((b & 0x7f) << 21);
    extraCount++;
}

// fourth
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

Located immediately after the header.

A block of UTF-8 strings with length prefixes (in bytes).
The entire block is compressed.

```
ushort length
byte[length] utf8data
```

---

## NODE BLOCK

```
varint nameOffset — points to the start of a string in the string block
byte type — 0 for file, 1 for directory
```

### type 0 (file):

```
varint data offset — from the start of the data block
varint data length
```

### type 1 (directory):

```
varint node count
node[node count] children
```

---

## DATA BLOCK

Located immediately after the node block.

Represents a binary blob.
