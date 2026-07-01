/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июля 2026 08:36:47
 * Version: 1.0.2523
 */

using System;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Class)]
public class ParsedIniAttribute : Attribute
{
    public bool Preparse { get; init; } = true;
}
