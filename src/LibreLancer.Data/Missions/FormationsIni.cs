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
