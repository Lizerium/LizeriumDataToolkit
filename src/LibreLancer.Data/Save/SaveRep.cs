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
