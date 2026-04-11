/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:39:36
 * Version: 1.0.2429
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

[ParsedSection]
public partial class Simple
{
    [Entry("nickname", Required = true)]
    public string Nickname;
    [Entry("DA_archetype", Required = true)]
    public string DaArchetypeName;
    [Entry("material_library", Multiline = true)]
    public List<string> MaterialLibrary = new();
    [Entry("mass")]
    public float Mass;
    [Entry("LODranges")]
    public float[] LODranges;
}
