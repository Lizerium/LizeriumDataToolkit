/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 апреля 2026 22:12:55
 * Version: 1.0.2419
 */

// MIT License - Copyright (c) Malte Rupprecht, Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.NewCharDB
{
    [ParsedSection]
    public partial class NewCharPackage
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("strid_name")]
        public int StridName;
        [Entry("strid_desc")]
        public int StridDesc;
        [Entry("ship")]
        public string Ship;
        [Entry("loadout")]
        public string Loadout;
        [Entry("money")]
        public long Money;
    }
}
