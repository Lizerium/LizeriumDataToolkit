/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июня 2026 16:36:05
 * Version: 1.0.2506
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Storyline;

[ParsedSection]
public partial class StoryMission
{
    [Entry("nickname", Required = true)] public string Nickname;
    [Entry("file", Required = true)] public string File;
}
