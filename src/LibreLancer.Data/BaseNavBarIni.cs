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
using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data
{
	public class BaseNavBarIni
	{
		public Dictionary<string, string> Navbar = new Dictionary<string, string>();

		public BaseNavBarIni() { }
        public BaseNavBarIni(string datapath, FileSystem vfs)
		{
			foreach (Section s in IniFile.ParseFile(datapath + "INTERFACE\\BASESIDE\\navbar.ini", vfs, true))
			{
				if (s.Name.ToLowerInvariant() == "navbar")
				{
					foreach (var e in s)
					{
						Navbar.Add(e.Name, e[0].ToString());
					}
				}
			}
		}
	}
}
