/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 сентября 2026 09:35:31
 * Version: 1.0.2605
 */

using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

[Conditional("JETBRAINS_ANNOTATIONS")]
class MeansImplicitUseAttribute : Attribute
{
}