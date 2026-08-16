/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:25:32
 * Version: 1.0.2569
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.NewCharDB
{
    [ParsedIni]
    public partial class NewCharDBIni
    {
        [Section("faction")]
        public List<NewCharFaction> Factions = new List<NewCharFaction>();
        [Section("package")]
        public List<NewCharPackage> Packages = new List<NewCharPackage>();
        [Section("pilot")]
        public List<NewCharPilot> Pilots = new List<NewCharPilot>();

        public void AddNewCharDBIni(string path, FileSystem vfs) => ParseIni(path, vfs);
    }
}
