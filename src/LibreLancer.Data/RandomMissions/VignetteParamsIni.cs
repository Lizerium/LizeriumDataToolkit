/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:45
 * Version: 1.0.2446
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.RandomMissions;

[ParsedIni]
public partial class VignetteParamsIni
{
    [Section("DataNode", typeof(DataNode))]
    [Section("DocumentationNode", typeof(DocumentationNode))]
    [Section("DecisionNode", typeof(DecisionNode))]
    public List<VignetteNode> Nodes = new List<VignetteNode>();

    public void AddFile(string path, FileSystem vfs) => ParseIni(path, vfs);
}
