/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package


namespace LibreLancer.Data.Universe
{
	public class JumpReference
	{
		public string System { get; private set; }
		public string Exit { get; private set; }
		public string TunnelEffect { get; private set; }

		public JumpReference(string toSystem, string exit, string tunnelEffect)
		{
			this.System = toSystem;
			this.Exit = exit;
			this.TunnelEffect = tunnelEffect;
		}
	}
}