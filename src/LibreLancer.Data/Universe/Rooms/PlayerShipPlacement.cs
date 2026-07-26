/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июля 2026 15:12:08
 * Version: 1.0.2548
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class PlayerShipPlacement
{
    [Entry("name")]
    public string Name;
    [Entry("launching_script")]
    public string LaunchingScript;
    [Entry("landing_script")]
    public string LandingScript;
}
