/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:25:32
 * Version: 1.0.2569
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
