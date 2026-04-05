/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class OnParseDependentAttribute : Attribute { }
