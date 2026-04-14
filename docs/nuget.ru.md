<p align="center">
  <b>Чтение, анализ и сериализация данных игр серии Freelancer</b>
</p>

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
