/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:40
 * Version: 1.0.2449
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DecisionNode : VignetteNode
{
    [Entry("nickname")] public string Nickname;
}
