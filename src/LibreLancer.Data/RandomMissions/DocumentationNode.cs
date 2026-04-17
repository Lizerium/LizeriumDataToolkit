/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:52:10
 * Version: 1.0.2441
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DocumentationNode : VignetteNode
{
    [Entry("documentation")]
    public string Documentation;
}
