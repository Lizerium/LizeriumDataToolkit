/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:48:41
 * Version: 1.0.2424
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer
{
	[Flags]
	public enum MouseButtons
	{
		None = 0,
		Left = 1,
		Right = 2,
		Middle = 4,
		X1 = 8,
		X2 = 16
	}
}

