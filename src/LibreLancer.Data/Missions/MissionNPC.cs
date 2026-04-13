/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Missions
{
    [ParsedSection]
    public partial class MissionNPC
    {
        [Entry("nickname")]
        public string Nickname;
        [Entry("space_costume")]
        public string[] SpaceCostume = new string[3];
        [Entry("affiliation")]
        public string Affiliation;
        [Entry("npc_ship_arch")]
        public string NpcShipArch;
        [Entry("individual_name")]
        public int IndividualName;
        [Entry("voice")]
        public string Voice;
    }

}
