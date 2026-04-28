/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:26:25
 * Version: 1.0.2453
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

namespace LibreLancer.Graphics.Text
{
	public class RichTextTextNode : RichTextNode
	{
		public bool Bold;
		public bool Italic;
		public bool Underline;
        public string FontName;
        public float FontSize;
		public Color4 Color = Color4.White;
        public OptionalColor Shadow;
        public OptionalColor Background;
		public TextAlignment Alignment;
		public string Contents;
	}
}

