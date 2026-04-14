# Locating Log Files

Логи для LancerEdit и движка Librelancer можно найти в следующих местах:

| Platform | Location                                                                      |
| -------- | ----------------------------------------------------------------------------- |
| Windows  | `%LocalAppData%\Librelancer\logs`                                             |
| Linux    | `$XDG_STATE_HOME/Librelancer/logs` (обычно `~/.local/state/Librelancer/logs`) |

_NOTE:_ `lleditscript` не создаёт лог-файлы вне консольного вывода.
При необходимости перенаправьте вывод `lleditscript` в файл.
