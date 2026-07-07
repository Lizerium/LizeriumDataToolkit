/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июля 2026 12:19:54
 * Version: 1.0.2529
 */

using System;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Class)]
public class ParsedIniAttribute : Attribute
{
    public bool Preparse { get; init; } = true;
}
