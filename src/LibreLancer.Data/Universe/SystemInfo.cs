/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2026 07:39:59
 * Version: 1.0.2588
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class SystemInfo
{
    [Entry("space_color")]
    public Color4 SpaceColor = Color4.Black;
    [Entry("local_faction")]
    public string LocalFaction;
    [Entry("rpop_solar_detection")]
    public bool? RpopSolarDetection;
    [Entry("space_farclip")]
    public float? SpaceFarClip;
}
