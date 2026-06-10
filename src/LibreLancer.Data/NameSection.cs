/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июня 2026 06:53:13
 * Version: 1.0.2502
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
