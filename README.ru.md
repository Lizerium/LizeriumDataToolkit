<h1 align="center">🌊 Freelancer Data Toolkit 🌊</h1>

<p align="center">
  <b>Чтение, анализ и сериализация данных игр серии Freelancer</b>
</p>

<p align="center">
  <img src="https://shields.dvurechensky.pro/badge/Status-Active-00C853?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/Use%20Case-Game%20Parsing-1565C0?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/.NET-Library-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/Freelancer-SDK-0A0A0A?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/JSON-Serialization-FF6F00?style=for-the-badge&logo=json&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/Origin-LibreLancer-9C27B0?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/nuget/v/Lizerium.Librelancer.DataBridge" />
</p>

<div align="center" style="margin: 20px 0; padding: 10px; background: #1c1917; border-radius: 10px;">
  <strong>🌐 Язык: </strong>
  
  <span style="color: #F5F752; margin: 0 10px;">
    ✅ 🇷🇺 Русский (текущий)
  </span>
  | 
  <a href="./README.md" style="color: #0891b2; margin: 0 10px;">
    🇺🇸 English
  </a>
</div>

---

> [!NOTE]
> Этот проект является частью экосистемы **Lizerium** и относится к направлению:
>
> - [`Lizerium.Tools.Structs`](https://github.com/Lizerium/Lizerium.Tools.Structs)
>
> Если вы ищете связанные инженерные и вспомогательные инструменты, начните оттуда.

## 📌 О проекте

Этот репозиторий представляет собой **выделенные и доработанные библиотеки** для работы с данными игры _Freelancer_, извлечённые из проекта **LibreLancer** и переработанные в самостоятельный инструмент.

> Проект больше не зависит от LibreLancer и поддерживается отдельно.

## ⚠️ Признательность

> [!NOTE]
> Этот проект основан на работе сообщества фрилансеров.
> Переработан и интегрирован в экосистему Lizerium.
>
> Авторы: [`CallumDev`](https://github.com/CallumDev), [`Lazrius`](https://github.com/Lazrius), [`smegulater`](https://github.com/smegulater), [`josbyte`](https://github.com/josbyte), [`mcgoober`](https://github.com/mcgoober), [`IrateRedKite`](https://github.com/IrateRedKite), [`bjstarosta`](https://github.com/bjstarosta), [`gp-alex`](https://github.com/gp-alex), [`JimJamJamie`](https://github.com/JimJamJamie), [`BC46`](https://github.com/BC46), [`Gnamra`](https://github.com/Gnamra), [`mrmbernardi`](https://github.com/mrmbernardi), [`HaydnTrigg`](https://github.com/HaydnTrigg), [`ananace`](https://github.com/ananace)

- [📌 О проекте](#-о-проекте)
- [⚠️ Признательность](#️-признательность)
- [⚠️ Важно](#️-важно)
- [✨ Что это даёт](#-что-это-даёт)
- [🚀 Быстрый старт](#-быстрый-старт)
  - [1) Подключение библиотек](#1-подключение-библиотек)
- [📖 Пример чтения данных игры](#-пример-чтения-данных-игры)
  - [💡 Что ты получаешь](#-что-ты-получаешь)
- [🧊 JSON сериализация](#-json-сериализация)
- [🔄 JSON десериализация](#-json-десериализация)
- [🧠 Архитектурная идея](#-архитектурная-идея)
- [🔥 Особенности](#-особенности)
- [📦 Где использовать](#-где-использовать)
- [📂 Скриншот](#-скриншот)
- [📉 Статус](#-статус)
- [📜 License \& Origin](#-license--origin)

---

## ⚠️ Важно

- Проект не используется в коммерческих целях
- Исходные компоненты были взяты из открытого проекта LibreLancer
- Использование в коммерции — на ваш страх и риск

---

## ✨ Что это даёт

С помощью этих библиотек можно:

- 📂 Читать структуру игры Freelancer целиком
- 🧠 Загружать все игровые данные в память
- 🔍 Анализировать конфигурации (`freelancer.ini` и др.)
- 🔁 Сериализовать состояние игры в JSON
- 🧩 Работать с модами (поддержка доработана)
- ⚙️ Строить свои инструменты:
  - Mod Manager
  - Анализаторы данных
  - Генераторы конфигов
  - Тестовые среды

---

## 🚀 Быстрый старт

### 1) Подключение библиотек

Собери проект и подключи:

- `Lizerium.Librelancer.DataBridge.dll`
- `LibreLancer.Base.dll`

(Готовые сборки доступны в разделе `Releases`)

---

## 📖 Пример чтения данных игры

```csharp
using LibreLancer.Data;

var freelancerPath = "C:\\Program Files (x86)\\Freelancer";

var vfs = LibreLancer.Data.IO.FileSystem.FromPath(freelancerPath);

var ini = new FreelancerIni(vfs);
var data = new FreelancerData(ini, vfs);
data.LoadData((msg) =>
{
    Console.WriteLine(msg);
});

Console.ReadLine();
```

### 💡 Что ты получаешь

- `ini` → конфигурация игры (`freelancer.ini`)
- `data` → **вся игра в памяти** (структуры, параметры, ресурсы)

---

## 🧊 JSON сериализация

```csharp
var settings = new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto
};

var json = JsonConvert.SerializeObject(data, settings);
File.WriteAllText("freelancer_dump.json", json);
```

---

## 🔄 JSON десериализация

```csharp
var settings = new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto
};

var json = File.ReadAllText("freelancer_dump.json");
var data = JsonConvert.DeserializeObject<FreelancerData>(json, settings);
```

---

## 🧠 Архитектурная идея

Инструмент работает как:

```
Freelancer Folder → VFS → INI → Data Model → JSON / Runtime
```

- Виртуальная файловая система (VFS)
- Парсинг конфигураций
- Построение полной модели игры
- Дальнейшая обработка

---

## 🔥 Особенности

- Поддержка модифицированных версий игры
- Расширенная загрузка данных
- Возможность полного snapshot'а состояния игры
- Минимальный вход — буквально **3 строки кода**

---

## 📦 Где использовать

Этот проект особенно полезен если ты:

- разрабатываешь моды для Freelancer
- делаешь инструменты анализа
- пишешь серверную логику (FLHook / кастомные сервера)
- хочешь автоматизировать работу с ресурсами игры

---

## 📂 Скриншот

<p align="center">
  <img src="media/devenv_1rKJMAqvRr.png" />
</p>

---

## 📉 Статус

Проект активно используется как **внутренний инструмент**, но может дорабатываться дальше.

---

## 📜 License & Origin

This project is based in part on code originally derived from the
[LibreLancer](https://github.com/Librelancer/Librelancer) project,
which is distributed under the [**MIT License**](LICENSE)

This repository contains extracted, adapted and modified components used
for reading, parsing and serializing Freelancer game data in a standalone form.

Original copyright belongs to:

- **Callum McGing, Librelancer Contributors (2013–2026)**
- **Malte Rupprecht (2011–2012)**
- **Mono.Xna Team (2006)**

All modifications and standalone toolkit integration in this repository
are maintained separately.

> [CREDITS](CREDITS.md)
