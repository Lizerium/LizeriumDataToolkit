/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 сентября 2026 09:35:31
 * Version: 1.0.2605
 */

using System;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Class)]
public class ParsedIniAttribute : Attribute
{
    public bool Preparse { get; init; } = true;
}
