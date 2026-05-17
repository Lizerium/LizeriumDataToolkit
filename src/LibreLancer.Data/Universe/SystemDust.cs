/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 мая 2026 11:11:54
 * Version: 1.0.2478
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class SystemDust
{
    [Entry("dust")]
    [Entry("spacedust")]
    public string Spacedust;
    [Entry("spacedust_maxparticles")]
    public int SpacedustMaxParticles;
}
