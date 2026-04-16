/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Goods
{
    [ParsedIni]
    public partial class GoodsIni
    {
        [Section("good")]
        public List<Good> Goods = new List<Good>();

        public void AddGoodsIni(string filename, FileSystem vfs) => ParseIni(filename, vfs);
    }
}
