/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 мая 2026 11:14:24
 * Version: 1.0.2484
 */

using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

[Conditional("JETBRAINS_ANNOTATIONS")]
class MeansImplicitUseAttribute : Attribute
{
}