/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 апреля 2026 08:11:37
 * Version: 1.0.2450
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
    public partial class MarketsIni
    {
        [Section("basegood")]
        public List<BaseGood> BaseGoods = new List<BaseGood>();

        public void AddMarketsIni(string filename, FileSystem vfs) => ParseIni(filename, vfs);
    }
}
