/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июля 2026 11:55:37
 * Version: 1.0.2532
 */

using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

[Conditional("JETBRAINS_ANNOTATIONS")]
class MeansImplicitUseAttribute : Attribute
{
}