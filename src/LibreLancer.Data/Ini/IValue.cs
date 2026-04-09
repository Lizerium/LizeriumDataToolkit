/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:58:14
 * Version: 1.0.2427
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

namespace LibreLancer.Data.Ini
{
	public interface IValue
	{
        bool TryToBoolean(out bool result);
        bool TryToInt32(out int result);
        bool TryToInt64(out long result);
        bool TryToSingle(out float result);

        bool ToBoolean();
		int ToInt32();
        long ToInt64();
        float ToSingle();

		StringKeyValue ToKeyValue();
	}
}
