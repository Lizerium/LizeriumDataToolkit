/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:07:11
 * Version: 1.0.2443
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
