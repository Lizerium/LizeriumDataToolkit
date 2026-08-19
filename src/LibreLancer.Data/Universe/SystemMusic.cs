/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 августа 2026 10:23:12
 * Version: 1.0.2572
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
