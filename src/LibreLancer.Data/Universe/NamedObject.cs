/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:26:25
 * Version: 1.0.2453
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package


using System;
using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
	public abstract class NamedObject
	{
        [Entry("nickname", Required = true)]
        public string Nickname;
        [Entry("pos")]
        public Vector3? Pos;
        [Entry("rotate")]
        public Vector3? Rotate;
        public override string ToString()
		{
			return Nickname;
		}
	}
}
