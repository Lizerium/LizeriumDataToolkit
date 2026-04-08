/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:27:48
 * Version: 1.0.2426
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    [ParsedSection]
    public partial class MissileReactionBlock : PilotBlock
    {
        [Entry("evade_missile_distance")] public float EvadeMissileDistance;
        [Entry("evade_break_missile_reaction_time")]
        public float EvadeBreakMissileReactionTime;
        [Entry("evade_slide_missile_reaction_time")]
        public float EvadeSlideMissileReactionTime;
        [Entry("evade_afterburn_missile_reaction_time")]
        public float EvadeAfterburnMissileReactionTime;
    }
}
