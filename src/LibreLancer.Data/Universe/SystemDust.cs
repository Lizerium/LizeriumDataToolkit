/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2026 12:06:31
 * Version: 1.0.2473
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
