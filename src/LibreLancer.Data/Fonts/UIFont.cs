/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 апреля 2026 06:53:08
 * Version: 1.0.2454
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data
{
    [ParsedSection]
    public partial class UIFont
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("font")]
        public string Font;
        [Entry("fixed_height")]
        public float FixedHeight;
    }
}
