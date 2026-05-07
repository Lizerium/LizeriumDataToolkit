/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 мая 2026 15:28:01
 * Version: 1.0.2468
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
