/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Interface;

[ParsedSection]
public partial class KeyCmd
{
    [Entry("nickname")] public string Nickname;
    [Entry("ids_name")] public int IdsName;
    [Entry("ids_info")] public int IdsInfo;
    [Entry("state")] public string[] State;
    [Entry("key")] public List<string[]> Keys = new List<string[]>();
}

[IgnoreSection("keymap=1.1")]
[IgnoreSection("KeyMap")]
[ParsedIni]
public partial class KeymapIni
{
    [Section("KeyCmd")]
    public List<KeyCmd> KeyCmd = new List<KeyCmd>();

    public KeymapIni() { }
    public KeymapIni(string path, FileSystem vfs)
    {
        ParseIni(path, vfs);
    }
}
