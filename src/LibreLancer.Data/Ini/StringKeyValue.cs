/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Data.Ini
{
	public class StringKeyValue : ValueBase
	{
        public string Key { get; init; }
		public string Value { get; init; }

		public StringKeyValue (string key, string value)
		{
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (value == null) throw new ArgumentNullException(nameof(value));

			Key = key;
			Value = value;
		}

        public override bool TryToBoolean(out bool result)
        {
            throw new InvalidCastException();
        }

        public override bool TryToInt32(out int result)
        {
            result = 0;
            return false;
        }

        public override bool TryToInt64(out long result)
        {
            throw new InvalidCastException();
        }

        public override bool TryToSingle(out float result)
        {
            throw new InvalidCastException();
        }

        public override StringKeyValue ToKeyValue()
		{
			return this;
		}
	}
}

