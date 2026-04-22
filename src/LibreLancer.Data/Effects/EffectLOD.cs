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
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Effects
{
    [ParsedSection]
    public partial class EffectLOD
    {
        [Entry("type", Required = true)]
        public string Type;
        [Entry("max_lod_screen_size")]
        public float MaxLodScreenSize;
        [Entry("min_lod_screen_size")]
        public float MinLodScreenSize;
        [Entry("min_screen_size")]
        public float MinScreenSize;
    }
}
