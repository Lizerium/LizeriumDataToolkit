/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:59:25
 * Version: 1.0.2422
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
