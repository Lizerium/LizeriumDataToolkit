/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 мая 2026 14:55:54
 * Version: 1.0.2492
 */

// MIT License - Copyright (c) Malte Rupprecht, Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.NewCharDB
{
    [ParsedSection]
    public partial class NewCharPilot
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("body")]
        public string Body;
        [Entry("comm")]
        public string Comm;
        [Entry("voice")]
        public string Voice;
        [Entry("body.anim")]
        public string BodyAnim;
        [Entry("comm.anim")]
        public string[] CommAnim;
    }
}
