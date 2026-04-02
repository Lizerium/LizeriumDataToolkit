/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 апреля 2026 06:52:26
 * Version: 1.0.2420
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
    [ParsedSection]
	public partial class NebulaLight
    {
        [Entry("ambient")]
        public Color4? Ambient;
        [Entry("sun_burnthrough_intensity")]
        public float? SunBurnthroughIntensity;
        [Entry("sun_burnthrough_scaler")]
        public float? SunBurnthroughScaler;
    }
}
