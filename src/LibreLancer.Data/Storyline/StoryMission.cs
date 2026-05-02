/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:17:31
 * Version: 1.0.2463
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Storyline;

[ParsedSection]
public partial class StoryMission
{
    [Entry("nickname", Required = true)] public string Nickname;
    [Entry("file", Required = true)] public string File;
}
