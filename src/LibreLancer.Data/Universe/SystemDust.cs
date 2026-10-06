/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 октября 2026 09:58:32
 * Version: 1.0.2620
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
