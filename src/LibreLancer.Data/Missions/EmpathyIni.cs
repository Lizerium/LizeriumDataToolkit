/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 августа 2026 06:53:19
 * Version: 1.0.2564
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
