/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public class DirectionWeight
    {
        public string Direction;
        public float Weight;

        public DirectionWeight()
        {
        }

        public DirectionWeight(Entry e)
        {
            Direction = e[0].ToString();
            Weight = e[1].ToSingle();
        }
    }
}
