/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 июня 2026 06:53:22
 * Version: 1.0.2504
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
	public abstract class ZoneReference
	{
        [Entry("file")]
		public string IniFile;
        [Entry("zone")]
		public string ZoneName;
        [Section("texturepanels")]
        public TexturePanelsRef TexturePanels;
        [Section("properties")]
        public ObjectProperties Properties;
    }
}
