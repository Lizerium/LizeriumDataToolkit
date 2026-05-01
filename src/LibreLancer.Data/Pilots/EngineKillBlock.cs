/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 мая 2026 06:53:12
 * Version: 1.0.2456
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
    public partial class EngineKillBlock : PilotBlock
    {
        [Entry("engine_kill_search_time")] public float SearchTime;
        [Entry("engine_kill_face_time")] public float FaceTime;
        [Entry("engine_kill_use_afterburner")] public bool UseAfterburner;
        [Entry("engine_kill_afterburner_time")]
        public float AfterburnerTime;
        [Entry("engine_kill_max_target_distance")]
        public float MaxTargetDistance;
    }
}
