/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июля 2026 08:47:56
 * Version: 1.0.2526
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
	public partial class InternalFx : AbstractEquipment
	{
        [Entry("use_animation")]
		public string UseAnimation;
        [Entry("use_sound")]
		public string UseSound;
	}
}
