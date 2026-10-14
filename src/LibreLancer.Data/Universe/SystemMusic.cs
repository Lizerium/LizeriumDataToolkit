/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2026 11:03:08
 * Version: 1.0.2627
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
