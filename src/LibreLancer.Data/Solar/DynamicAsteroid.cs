/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Solar;

[ParsedSection]
public partial class DynamicAsteroid
{
    [Entry("nickname", Required = true)]
    public string Nickname;
    [Entry("DA_archetype")]
    public string DaArchetype;
    [Entry("material_library")]
    public string MaterialLibrary;
    [Entry("explosion_arch")]
    public string ExplosionArch;
}
