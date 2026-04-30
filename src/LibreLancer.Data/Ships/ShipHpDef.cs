/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:20:31
 * Version: 1.0.2455
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
