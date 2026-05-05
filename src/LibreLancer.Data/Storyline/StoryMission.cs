/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 мая 2026 07:02:13
 * Version: 1.0.2466
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Storyline;

[ParsedSection]
public partial class StoryMission
{
    [Entry("nickname", Required = true)] public string Nickname;
    [Entry("file", Required = true)] public string File;
}
