/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Graphics.Backends;

namespace LibreLancer.Graphics
{
	public class MultisampleTarget : RenderTarget
	{
        public int Width => impl.Width;
        public int Height => impl.Height;

        private IMultisampleTarget impl;

		public MultisampleTarget(RenderContext renderContext, int width, int height, int samples)
        {
            impl = renderContext.Backend.CreateMultisampleTarget(width, height, samples);
            Target = impl;
        }

        public void BlitToScreen(Point offset) => impl.BlitToScreen(offset);

        public void BlitToRenderTarget(RenderTarget2D rTarget) =>
            impl.BlitToRenderTarget(rTarget.Backing);

        public override void Dispose() => impl.Dispose();
    }
}
