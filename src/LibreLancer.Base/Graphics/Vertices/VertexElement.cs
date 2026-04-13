/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
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

