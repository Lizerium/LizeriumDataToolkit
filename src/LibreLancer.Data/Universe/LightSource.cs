/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:53:35
 * Version: 1.0.2448
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package


using System;
using System.Collections.Generic;
using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe
{
    [ParsedSection]
	public partial class LightSource : NamedObject
    {
        [Entry("ids_name")]
        public int IdsName;
        [Entry("color")]
        public Color4? Color;
        [Entry("range")]
        public int? Range;
        [Entry("type")]
        public LightType? Type;
        [Entry("atten_curve")]
        public string AttenCurve;
        [Entry("attenuation")]
        public Vector3? Attenuation;
        [Entry("direction")]
        public Vector3? Direction;
    }
}
