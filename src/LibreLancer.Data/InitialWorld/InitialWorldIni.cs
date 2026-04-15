/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:33
 * Version: 1.0.2436
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.InitialWorld
{
    [ParsedIni]
    public partial class InitialWorldIni
    {
        [Section("locked_gates")]
        public List<LockedGates> LockedGates = new List<LockedGates>();

        [Section("group")]
        public List<FlGroup> Groups = new List<FlGroup>();

        public void AddFile(string path, FileSystem vfs) => ParseIni(path, vfs);
    }
}
