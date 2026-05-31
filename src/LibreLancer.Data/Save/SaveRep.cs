/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 мая 2026 14:55:54
 * Version: 1.0.2492
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save
{
    public class SaveRep
    {
        public float Reputation;
        public string Group;
        public SaveRep() { }
        public SaveRep(Entry e)
        {
            Reputation = e[0].ToSingle();
            Group = e[1].ToString();
        }
    }
}
