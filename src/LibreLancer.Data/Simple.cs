/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 апреля 2026 08:11:37
 * Version: 1.0.2450
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
