/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:27:48
 * Version: 1.0.2426
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Data.Ini
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class EntryAttribute : Attribute
    {
        public string Name;
        public bool MinMax = false;
        public bool Multiline = false;
        public bool Presence = false;
        public bool Required = false;
        public bool FloatColor = false;
        public Vec3Mode Mode = Vec3Mode.None;
        public EntryAttribute(string name)
        {
            Name = name;
        }
    }

    public enum Vec3Mode
    {
        None = 0,
        Size = 1,
        OptionalComponents = 2
    }
}
