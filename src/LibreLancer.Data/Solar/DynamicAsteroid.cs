/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2026 09:42:09
 * Version: 1.0.2607
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
