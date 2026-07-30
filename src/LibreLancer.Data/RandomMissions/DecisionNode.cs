/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 июля 2026 06:53:04
 * Version: 1.0.2552
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

[ParsedSection]
public partial class DecisionNode : VignetteNode
{
    [Entry("nickname")] public string Nickname;
}
