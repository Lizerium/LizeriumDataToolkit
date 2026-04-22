/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:38:05
 * Version: 1.0.2447
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
    public partial class MineBlock : PilotBlock
    {
        [Entry("mine_launch_interval")] public float LaunchInterval;
        [Entry("mine_launch_cone_angle")] public float LaunchConeAngle;
        [Entry("mine_launch_range")] public float LaunchRange;
    }
}
