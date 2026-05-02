/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:17:31
 * Version: 1.0.2463
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
	public partial class Thruster : AbstractEquipment
	{
		[Entry("particles")]
		public string Particles;
        [Entry("hp_particles")]
		public string HpParticles;
        [Entry("max_force")]
		public int MaxForce;
        [Entry("power_usage")]
		public int PowerUsage;
	}
}
