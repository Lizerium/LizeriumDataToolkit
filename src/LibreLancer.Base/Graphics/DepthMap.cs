/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июня 2026 18:22:25
 * Version: 1.0.2499
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System.Numerics;
using LibreLancer.Graphics.Backends;

namespace LibreLancer.Graphics
{
	public class DepthMap : Texture2D
    {
        internal IDepthMap DepthBacking;
		public DepthMap(RenderContext context, int width, int height)
        {
            DepthBacking = context.Backend.CreateDepthMap(width, height);
            SetBacking2D(DepthBacking);
        }

        public void BindFramebuffer() => DepthBacking.BindFramebuffer();
        public override void Dispose() => DepthBacking.Dispose();
    }
}
