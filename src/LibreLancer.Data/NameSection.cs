/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:52:10
 * Version: 1.0.2441
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
