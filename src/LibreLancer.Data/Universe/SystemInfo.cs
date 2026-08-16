/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:25:32
 * Version: 1.0.2569
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
