/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

[ParsedSection]
public partial class NameSection
{
    [Entry("name")]
    public string Name;

    public override string ToString() => Name;
}
