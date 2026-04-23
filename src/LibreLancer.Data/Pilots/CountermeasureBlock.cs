/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:53:35
 * Version: 1.0.2448
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
    public partial class CountermeasureBlock : PilotBlock
    {
        [Entry("countermeasure_active_time")] public float ActiveTime;
        [Entry("countermeasure_unactive_time")] //Not a typo
        public float UnactiveTime;
    }
}
