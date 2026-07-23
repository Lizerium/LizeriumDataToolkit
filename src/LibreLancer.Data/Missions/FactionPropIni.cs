/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 июля 2026 12:56:53
 * Version: 1.0.2545
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
