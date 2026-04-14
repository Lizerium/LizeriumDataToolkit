/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:25:20
 * Version: 1.0.2432
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;



[MeansImplicitUse]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class EntryHandlerAttribute : Attribute
{
    public int MinComponents = 0;
    public bool Multiline = false;
    public string Name;

    public EntryHandlerAttribute(string name)
    {
        Name = name;
    }
}
