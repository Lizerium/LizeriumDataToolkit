/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 июля 2026 14:57:34
 * Version: 1.0.2549
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DocumentationNode : VignetteNode
{
    [Entry("documentation")]
    public string Documentation;
}
