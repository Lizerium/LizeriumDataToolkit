/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:48:39
 * Version: 1.0.2498
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
    [ParsedSection]
    public partial class NebulaBackgroundLightning
    {
        [Entry("duration")]
        public float Duration;
        [Entry("gap")]
        public float Gap;
        [Entry("color")]
        public Color4 Color;
    }
}
