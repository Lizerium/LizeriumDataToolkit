/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 сентября 2026 10:33:13
 * Version: 1.0.2600
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class OnParseDependentAttribute : Attribute { }
