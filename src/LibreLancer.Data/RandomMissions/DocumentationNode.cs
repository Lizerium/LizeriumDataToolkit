/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2026 12:03:54
 * Version: 1.0.2665
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DocumentationNode : VignetteNode
{
    [Entry("documentation")]
    public string Documentation;
}
