/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:58:14
 * Version: 1.0.2427
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Data.Universe
{
	public class TextureShape
	{
		public string TextureName;
		public string ShapeName;
		public RectangleF Dimensions;
		public TextureShape (string texname, string shapename, RectangleF dimensions)
		{
			TextureName = texname;
			ShapeName = shapename;
			Dimensions = dimensions;
		}
	}
}

