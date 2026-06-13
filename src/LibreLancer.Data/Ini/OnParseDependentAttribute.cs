/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 июня 2026 14:01:44
 * Version: 1.0.2505
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class OnParseDependentAttribute : Attribute { }
