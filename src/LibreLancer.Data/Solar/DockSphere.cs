/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:59
 * Version: 1.0.2442
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package
using System;
namespace LibreLancer.Data.Solar
{
    public enum DockSphereType
    {
        berth,
        moor_small,
        moor_medium,
        moor_large,
        ring,
        airlock
    }
	public class DockSphere
	{
		public DockSphereType Type;
		public string Hardpoint;
		public int Radius;
		public string Script;
		public DockSphere()
		{
		}
	}
}
