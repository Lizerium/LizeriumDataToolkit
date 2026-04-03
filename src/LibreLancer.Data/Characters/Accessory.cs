/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Characters
{
    [ParsedSection]
	public partial class Accessory
	{
        [Entry("nickname", Required = true)]
        public string Nickname;
        [Entry("mesh")]
        public string Mesh;
        [Entry("hardpoint")]
        public string Hardpoint;
        [Entry("body_hardpoint")]
        public string BodyHardpoint;
	}
}
