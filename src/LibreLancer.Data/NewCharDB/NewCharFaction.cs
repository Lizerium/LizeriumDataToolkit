/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:20:31
 * Version: 1.0.2455
 */

// MIT License - Copyright (c) Malte Rupprecht, Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.NewCharDB
{
    [ParsedSection]
    public partial class NewCharFaction
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("rep_group")]
        public string RepGroup;
        [Entry("base")]
        public string Base;
        [Entry("package")]
        public string Package;
        [Entry("pilot")]
        public string Pilot;
    }
}
