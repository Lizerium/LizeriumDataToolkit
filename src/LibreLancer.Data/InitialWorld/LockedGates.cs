/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июля 2026 10:11:00
 * Version: 1.0.2550
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
