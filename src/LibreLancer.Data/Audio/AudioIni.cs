/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Audio
{
    [ParsedIni]
    public partial class AudioIni
    {
        [Section("sound")]
        public List<AudioEntry> Entries = new List<AudioEntry>();
        public void AddIni(string path, FileSystem vfs)
        {
            ParseIni(path, vfs);
        }
    }
}
