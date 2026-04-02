/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 апреля 2026 06:52:26
 * Version: 1.0.2420
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
