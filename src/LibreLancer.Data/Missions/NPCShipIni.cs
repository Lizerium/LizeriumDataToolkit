/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 апреля 2026 09:57:02
 * Version: 1.0.2451
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package
using System.Collections.Generic;
using System;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Missions
{
    [ParsedIni]
    public partial class NPCShipIni
    {
        [Section("NPCShipArch")]
        public List<NPCShipArch> ShipArches = new List<NPCShipArch>();
        public NPCShipIni() { }
        public NPCShipIni(string path, FileSystem vfs)
        {
            ParseIni(path, vfs);
        }
    }


    [ParsedSection]
    public partial class NPCShipArch
    {
        [Entry("nickname")] public string Nickname;
        [Entry("loadout")] public string Loadout;
        public int Level;
        [Entry("ship_archetype")] public string ShipArchetype;
        [Entry("pilot")] public string Pilot;
        [Entry("state_graph")] public string StateGraph;
        [Entry("npc_class")] public List<string> NpcClass = new List<string>();

        [EntryHandler("level", MinComponents = 1)]
        private void LevelEntry(Entry e)
        {
            var level = e[0].ToString();
            var index = level?.IndexOfAny("0123456789".ToCharArray());

            if (index is null)
            {
                Level = 0;
                return;
            }

            _ = int.TryParse(level.AsSpan(index.Value), out Level);
        }
    }
}
