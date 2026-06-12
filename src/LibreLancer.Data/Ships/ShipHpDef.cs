/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 июня 2026 06:53:22
 * Version: 1.0.2504
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System.Linq;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Ships
{
    public class ShipHpDef
    {
        public string Type;
        public string[] Hardpoints;

        public ShipHpDef()
        {
        }

        public ShipHpDef(Entry e)
        {
            Type = e[0].ToString();
            Hardpoints = e.Skip(1).Select(x => x.ToString()).ToArray();
        }
    }
}
