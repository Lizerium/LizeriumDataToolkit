/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 апреля 2026 08:11:37
 * Version: 1.0.2450
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System.Numerics;

namespace LibreLancer
{
	public interface ICamera
	{
		Matrix4x4 ViewProjection { get; }
		Matrix4x4 Projection { get; }
		Matrix4x4 View { get; }
		Vector3 Position { get; }

        bool FrustumCheck(BoundingSphere sphere);
        bool FrustumCheck(BoundingBox box);
	}
}

