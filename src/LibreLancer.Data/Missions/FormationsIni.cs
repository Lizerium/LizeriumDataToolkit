/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
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
