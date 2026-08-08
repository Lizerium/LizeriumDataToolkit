/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 августа 2026 06:53:20
 * Version: 1.0.2561
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Data.Ini
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class SectionAttribute : Attribute
    {
        public string Name;
        public string[] Delimiters;
        public Type Type;
        public bool Child;
        public SectionAttribute(string name, Type type = null)
        {
            Name = name;
            Type = type;
        }
    }
}
