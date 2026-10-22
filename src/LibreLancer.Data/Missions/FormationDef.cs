/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2026 09:51:13
 * Version: 1.0.2635
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
