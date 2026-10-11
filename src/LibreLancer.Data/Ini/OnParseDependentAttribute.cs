/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2026 11:52:38
 * Version: 1.0.2625
 */

using System;
using JetBrains.Annotations;

namespace LibreLancer.Data.Ini;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class OnParseDependentAttribute : Attribute { }
