/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 августа 2026 06:53:40
 * Version: 1.0.2554
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
