/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 мая 2026 07:50:48
 * Version: 1.0.2476
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
