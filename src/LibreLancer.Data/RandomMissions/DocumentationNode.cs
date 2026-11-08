/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 ноября 2026 13:31:03
 * Version: 1.0.2652
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DocumentationNode : VignetteNode
{
    [Entry("documentation")]
    public string Documentation;
}
