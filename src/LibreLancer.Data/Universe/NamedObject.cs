/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 июля 2026 11:01:06
 * Version: 1.0.2539
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
