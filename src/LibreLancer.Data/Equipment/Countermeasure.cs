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

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
    public partial class Countermeasure : Munition
    {
        [Entry("range")]
        public float Range;
        [Entry("owner_safe_time")]
        public float OwnerSafeTime;
        [Entry("diversion_pctg")]
        public float DiversionPercentage;
        [Entry("linear_drag")]
        public float LinearDrag;
    }
}
