/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2026 08:50:46
 * Version: 1.0.2629
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
