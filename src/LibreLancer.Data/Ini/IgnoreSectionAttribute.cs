/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
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
