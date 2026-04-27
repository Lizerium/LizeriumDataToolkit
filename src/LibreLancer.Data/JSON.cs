/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 апреля 2026 09:42:08
 * Version: 1.0.2452
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibreLancer.Data
{
	//Wrap around JsonSerializer
	public class JSON
	{
		public static T Deserialize<T>(string str)
        {
            return JsonSerializer.Deserialize<T>(str, new JsonSerializerOptions()
            {
                IncludeFields = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            });
        }
		public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize<T>(obj, new JsonSerializerOptions()
            {
                WriteIndented = true,
                IncludeFields = true,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            });
        }
	}
}
