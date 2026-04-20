/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:22:24
 * Version: 1.0.2444
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class AsteroidExclusion
{
    [Entry("exclude")]
    [Entry("exclusion")]
    public string ZoneName;
    [Entry("exclude_billboards")]
    public bool ExcludeBillboards;
    [Entry("exclude_dynamic_asteroids")]
    public bool ExcludeDynamicAsteroids;
    [Entry("empty_cube_frequency")]
    public float? EmptyCubeFrequency;
    [Entry("billboard_count")]
    public int? BillboardCount;
}
