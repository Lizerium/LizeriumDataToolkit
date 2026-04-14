/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:25:20
 * Version: 1.0.2432
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package
using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Missions
{
    [ParsedSection]
    public partial class ObjList : IEntryHandler
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("system")]
        public string System;
        public List<ObjCmd> Commands = new List<ObjCmd>();


        bool IEntryHandler.HandleEntry(Entry e)
        {
            ObjListCommands c;
            if(Enum.TryParse<ObjListCommands>(e.Name, true, out c))
            {
                Commands.Add(new ObjCmd() { Command = c, Entry = e });
                return true;
            }
            return false;
        }
    }
    public class ObjCmd
    {
        public ObjListCommands Command;
        public Entry Entry;
    }
}
