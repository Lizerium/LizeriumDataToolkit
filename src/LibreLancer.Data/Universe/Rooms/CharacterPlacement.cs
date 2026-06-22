/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 июня 2026 06:53:25
 * Version: 1.0.2514
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class CharacterPlacement
{
    [Entry("name")]
    public string Name;
    [Entry("start_script")]
    public string StartScript;
}
