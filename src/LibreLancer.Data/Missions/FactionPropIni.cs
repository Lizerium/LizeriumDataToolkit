/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 ноября 2026 11:15:39
 * Version: 1.0.2669
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Missions
{
    [ParsedIni]
    public partial class FactionPropIni
    {
        [Section("FactionProps")]
        public List<FactionProps> FactionProps = new List<FactionProps>();

        public void AddFile(string path, FileSystem vfs) => ParseIni(path, vfs);
    }
}
