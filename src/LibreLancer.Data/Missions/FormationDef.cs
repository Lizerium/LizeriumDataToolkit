/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 апреля 2026 22:12:55
 * Version: 1.0.2419
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
