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

namespace LibreLancer.Graphics.Vertices
{
	public class VertexDeclaration
	{
		public int Stride;
		public VertexElement[] Elements;

		public VertexDeclaration (int stride, params VertexElement[] elements)
		{
			Stride = stride;
			Elements = elements;
		}
	}
}

