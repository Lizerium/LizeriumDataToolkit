/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 апреля 2026 09:42:08
 * Version: 1.0.2452
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Graphics.Backends.OpenGL;

namespace LibreLancer.Graphics
{
	public enum WrapMode
	{
		ClampToEdge = GL.GL_CLAMP_TO_EDGE,
		ClampToBorder = GL.GL_CLAMP_TO_BORDER,
		MirroredRepeat = GL.GL_MIRRORED_REPEAT,
        Repeat = GL.GL_REPEAT
	}
}

