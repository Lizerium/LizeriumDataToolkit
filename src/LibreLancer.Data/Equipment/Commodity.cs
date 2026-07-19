/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 июля 2026 10:01:20
 * Version: 1.0.2541
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
    public partial class Commodity : AbstractEquipment
    {
        [Entry("pod_appearance")] public string PodAppearance;
        [Entry("decay_per_second")] public int DecayPerSecond;
    }
}
