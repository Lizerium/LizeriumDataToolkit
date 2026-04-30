/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:20:31
 * Version: 1.0.2455
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Solar
{
    [ParsedSection]
	public partial class StarGlow
	{
        [Entry("nickname")]
		public string Nickname;
        [Entry("shape")]
		public string Shape;
        [Entry("scale")]
		public int Scale;
        [Entry("inner_color", FloatColor=true)]
		public Color3f InnerColor;
        [Entry("outer_color", FloatColor=true)]
		public Color3f OuterColor;
	}
}

