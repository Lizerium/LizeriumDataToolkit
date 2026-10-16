/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2026 08:50:46
 * Version: 1.0.2629
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using LibreLancer.Graphics.Backends;

namespace LibreLancer.Graphics
{
	public class DepthBuffer : IDisposable
    {
        internal IDepthBuffer Backing;
		public DepthBuffer(RenderContext context, int width, int height)
        {
            Backing = context.Backend.CreateDepthBuffer(width, height);
		}
		public void Dispose()
        {
            Backing.Dispose();
        }
	}
}

