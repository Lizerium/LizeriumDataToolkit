/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
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
