/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июля 2026 08:36:47
 * Version: 1.0.2523
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class SystemMusic
{
    [Entry("space")]
    public string Space;
    [Entry("danger")]
    public string Danger;
    [Entry("battle")]
    public string Battle;
}
