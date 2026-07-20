/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 июля 2026 12:10:56
 * Version: 1.0.2542
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
