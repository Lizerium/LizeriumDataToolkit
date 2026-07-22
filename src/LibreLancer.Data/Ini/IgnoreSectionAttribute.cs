/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 июля 2026 12:57:03
 * Version: 1.0.2544
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
