/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 августа 2026 06:53:25
 * Version: 1.0.2576
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class SystemAmbient
{
    [Entry("color")]
    public Color3f Color;
}
