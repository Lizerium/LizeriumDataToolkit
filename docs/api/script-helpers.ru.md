<!-- API -->

# Script Helpers

Эти методы доступны в любой программе `lleditscript`.
Функции для задания опций должны вызываться **до** `ParseArguments`.

```csharp
// Вспомогательные функции

// Обработка опций
// Булева опция для установки флага
void FlagOption(string prototype, string description, Action<bool> action);

// Пример:

    bool verbose = false;
    FlagOption("v|verbose", "Подробное логирование", v => verbose = v);

// Целочисленная опция
// Позволяет задать значение через --option=123
void IntegerOption(string prototype, string description, Action<int> action)

// Пример:
    int count = 0;
    IntegerOption("count=", "Количество", v => count = v);

// Строковая опция
// Позволяет задать значение через --option="abc"
void StringOption(string prototype, string description, Action<string> action)

// Пример:
    string name = "";
    StringOption("name=", "Имя объекта", v => name = v);

// ScriptUsage
// Устанавливает сообщение использования (usage), которое выводится,
// если передано меньше аргументов, чем требуется
void ScriptUsage(string usage);

// ParseArguments
// Выполняет разбор всех опций, заданных через *Option функции,
// затем возвращает массив оставшихся аргументов.
// При необходимости выводит usage и завершает выполнение,
// если аргументов меньше минимально допустимого количества.
string[] ParseArguments(int minArgs = 0);


// Проверяет существование файла и завершает программу с кодом ошибки 2,
// если файл не найден
void AssertFileExists(string filename);
void AssertFilesExist(IEnumerable<string> filenames);

```
