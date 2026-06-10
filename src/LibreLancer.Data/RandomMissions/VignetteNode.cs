/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июня 2026 06:53:13
 * Version: 1.0.2502
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.RandomMissions;

public abstract class VignetteNode
{
    [Entry("node_id", Required = true)] public int NodeId;
    [Entry("child_node", Multiline = true)] public List<int> ChildId = new List<int>();
}
