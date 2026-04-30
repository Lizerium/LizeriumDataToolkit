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

namespace LibreLancer.Data.Pilots
{
    [ParsedSection]
    public partial class StrafeBlock : PilotBlock
    {
        [Entry("strafe_run_away_distance")] public float RunAwayDistance;
        [Entry("strafe_attack_throttle")] public float AttackThrottle;
        [Entry("strafe_turn_throttle")] public float TurnThrottle;
    }
}
