/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 апреля 2026 22:12:55
 * Version: 1.0.2419
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer
{
	public class KeyEventArgs
	{
		public Keys Key { get; private set; }
		public KeyModifiers Modifiers { get; private set; }
		public bool IsRepeat { get; private set; }
		public KeyEventArgs (Keys key, KeyModifiers mod, bool repeat)
		{
			Key = key;
			Modifiers = mod;
			IsRepeat = repeat;
		}
	}
}

