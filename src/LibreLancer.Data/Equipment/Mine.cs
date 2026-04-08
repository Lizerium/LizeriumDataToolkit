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

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
    public partial class Mine : Munition
    {
        [Entry("acceleration")] public float Acceleration;
        [Entry("top_speed")] public float TopSpeed;
        [Entry("owner_safe_time")] public float OwnerSafeTime;
        [Entry("linear_drag")] public float LinearDrag;
        [Entry("seek_dist")] public float SeekDist;
    }
}
