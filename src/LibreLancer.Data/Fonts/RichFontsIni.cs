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

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data
{
	public class RichFontsIni
	{
		public List<RichFont> Fonts = new List<RichFont>();
		public void AddRichFontsIni(string path, FileSystem vfs)
		{
			foreach (var section in IniFile.ParseFile(path, vfs))
			{
				if (section.Name.ToLowerInvariant() == "truetype")
				{
					foreach (var e in section)
					{
						if (e.Name.ToLowerInvariant() == "font")
						{
							Fonts.Add(new RichFont() { Index = e[0].ToInt32(), Name = e[1].ToString(), Size = e[2].ToInt32() });
						}
					}
				}
			}
		}
	}
}
