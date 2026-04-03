/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
    public partial class Tractor : AbstractEquipment
    {
        [Entry("max_length")] public float MaxLength;
        [Entry("reach_speed")] public float ReachSpeed;
        [Entry("color")] public Color3f Color;
        [Entry("operating_effect")] public string OperatingEffect;
        [Entry("tractor_complete_snd")] public string TractorCompleteSnd;
    }
}
