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

namespace LibreLancer.Data.Pilots
{
    [ParsedSection]
    public partial class TrailBlock : PilotBlock
    {
        [Entry("trail_lock_cone_angle")] public float LockConeAngle;
        [Entry("trail_break_time")] public float BreakTime;
        [Entry("trail_min_no_lock_time")] public float MinNoLockTime;
        [Entry("trail_break_roll_throttle")] public float BreakRollThrottle;
        [Entry("trail_break_afterburner")] public bool BreakAfterburner;
        [Entry("trail_max_turn_throttle")] public float MaxTurnThrottle;
        [Entry("trail_distance")] public float Distance;
    }
}
