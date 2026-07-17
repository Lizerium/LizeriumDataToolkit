/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 июля 2026 11:01:06
 * Version: 1.0.2539
 */

using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Missions;

[ParsedSection]
public partial class FormationDef
{
    [Entry("nickname", Required = true)] public string Nickname;
    [Entry("pos", Multiline = true)] public List<Vector3> Positions = new List<Vector3>();
    [Entry("pl_pos")] public Vector3? PlayerPosition;
}
