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

using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;

namespace LibreLancer.Graphics.Vertices
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VertexPosition : IVertexType
    {
        public Vector3 Position;

        public VertexPosition(Vector3 position)
            : this()
        {
            this.Position = position;
        }

		public VertexDeclaration GetVertexDeclaration()
		{
			return new VertexDeclaration(
				sizeof(float) * 3,
				new VertexElement(VertexSlots.Position, 3, VertexElementType.Float, false, 0)
			);
		}
    }
}
