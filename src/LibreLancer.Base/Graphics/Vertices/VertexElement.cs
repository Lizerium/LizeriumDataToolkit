/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

namespace LibreLancer.Graphics.Vertices
{
	public struct VertexElement
	{
		public int Slot;
		public int Elements;
		public VertexElementType Type;
		public bool Normalized;
		public int Offset;

        public bool Integer;

		public VertexElement (int slot, int elems, VertexElementType type, bool normalized, int offset, bool integer = false)
		{
			Slot = slot;
			Elements = elems;
			Type = type;
			Normalized = normalized;
			Offset = offset;
            Integer = integer;
        }
	}
}

