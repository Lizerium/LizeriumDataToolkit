/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:22:24
 * Version: 1.0.2444
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Missions;

[ParsedIni]
public partial class FormationsIni
{
    [Section("Formation")] public List<FormationDef> Formations = new List<FormationDef>();

    public void AddFile(string filename, FileSystem vfs)
    {
        ParseIni(filename, vfs);
    }

}
