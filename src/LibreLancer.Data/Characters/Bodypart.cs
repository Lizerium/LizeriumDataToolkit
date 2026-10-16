/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2026 08:50:46
 * Version: 1.0.2629
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Characters
{
    [ParsedSection]
	public partial class Bodypart
    {
        [Entry("nickname", Required = true)]
        public string Nickname;

        [Entry("mesh")]
        public string Mesh;

        public string Sex;
    }
}
