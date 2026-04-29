/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 апреля 2026 06:53:08
 * Version: 1.0.2454
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
