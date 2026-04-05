/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using System.Linq;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Characters
{
    [ParsedSection]
	public partial class Costume
    {
        [Entry("nickname", Required = true)] public string Nickname;
        [Entry("head")] public string Head;
        [Entry("body")] public string Body;
        [Entry("righthand")] public string RightHand;
        [Entry("lefthand")] public string LeftHand;
        [Entry("accessory")] public string Accessory;
	}
}
