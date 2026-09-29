/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 сентября 2026 09:41:42
 * Version: 1.0.2613
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
