/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2026 06:52:16
 * Version: 1.0.2657
 */

using System;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class IgnoreSectionAttribute : Attribute
{
    public string Name;
    public IgnoreSectionAttribute(string name)
    {
        Name = name;
    }
}
