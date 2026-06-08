/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 июня 2026 06:53:04
 * Version: 1.0.2500
 */

using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

[Conditional("JETBRAINS_ANNOTATIONS")]
class MeansImplicitUseAttribute : Attribute
{
}