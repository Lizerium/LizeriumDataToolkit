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

