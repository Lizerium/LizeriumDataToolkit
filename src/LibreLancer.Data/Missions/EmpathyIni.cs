/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2026 09:16:14
 * Version: 1.0.2655
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Missions
{
    [ParsedIni]
    public partial class EmpathyIni
    {
        [Section("RepChangeEffects")]
        public List<RepChangeEffects> RepChangeEffects = new List<RepChangeEffects>();

        public void AddFile(string path, FileSystem vfs) => ParseIni(path, vfs);
    }
}
