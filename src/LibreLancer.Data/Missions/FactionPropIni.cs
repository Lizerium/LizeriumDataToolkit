/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:25:32
 * Version: 1.0.2569
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
