/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:07:11
 * Version: 1.0.2443
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Graphics.Backends.OpenGL
{
    class GLDepthBuffer : IDepthBuffer
    {
        internal uint ID;

        public GLDepthBuffer(int width, int height)
        {
            ID = GL.GenRenderbuffer();
            GL.BindRenderbuffer(GL.GL_RENDERBUFFER, ID);
            GL.RenderbufferStorage(GL.GL_RENDERBUFFER, GL.GL_DEPTH_COMPONENT24, width, height);
        }
        public void Dispose()
        {
            GL.DeleteRenderbuffer(ID);
        }
    }
}
