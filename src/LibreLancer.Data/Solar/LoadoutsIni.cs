/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:59:25
 * Version: 1.0.2422
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using System.Linq;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Solar
{
    [ParsedIni]
	public partial class LoadoutsIni
	{
        [Section("loadout")]
        public List<Loadout> Loadouts = new List<Loadout>();

		public void AddLoadoutsIni(string path, FreelancerData gdata)
        {
            ParseIni(path, gdata.VFS);
        }
    }
}
