/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 октября 2026 10:57:22
 * Version: 1.0.2615
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.InitialWorld;

[ParsedSection]
public partial class LockedGates
{
    [Entry("locked_gate", Multiline = true)]
    public List<int> Locked = new List<int>();

    [Entry("npc_locked_gate", Multiline = true)]
    public List<int> NpcLockedGates = new List<int>();
}
