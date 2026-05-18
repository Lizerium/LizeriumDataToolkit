/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 мая 2026 12:50:09
 * Version: 1.0.2479
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Effects
{
    [ParsedSection]
	public partial class VisEffect
	{
        [Entry("nickname")]
		public string Nickname;
        [Entry("effect_crc")]
		public int EffectCrc;
        [Entry("alchemy")]
		public string AlchemyPath;
        [Entry("textures", Multiline = true)]
		public List<string> Textures = new List<string>();
	}
}
