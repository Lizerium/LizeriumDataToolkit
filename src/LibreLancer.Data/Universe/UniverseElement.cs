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

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{

	public abstract class UniverseElement
	{
        [Entry("nickname")]
        public string Nickname;
        [Entry("strid_name")]
        public int IdsName;
        [Entry("name")]
        public string Name;

		public override string ToString()
		{
			return Nickname;
		}
	}
}
