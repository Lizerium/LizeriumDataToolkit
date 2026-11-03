/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 ноября 2026 12:19:51
 * Version: 1.0.2647
 */

using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

[Conditional("JETBRAINS_ANNOTATIONS")]
class MeansImplicitUseAttribute : Attribute
{
}