/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 ноября 2026 11:30:22
 * Version: 1.0.2656
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class OnParseDependentAttribute : Attribute { }
