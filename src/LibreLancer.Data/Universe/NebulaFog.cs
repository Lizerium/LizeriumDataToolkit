/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
    [ParsedSection]
    public partial class NebulaFog
    {
        [Entry("fog_enabled")]
        public int Enabled;
        [Entry("near")]
        public int Near;
        [Entry("distance")]
        public int Distance;
        [Entry("color")]
        public Color4 Color;
    }
}
