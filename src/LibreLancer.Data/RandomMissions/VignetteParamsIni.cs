/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 мая 2026 11:13:35
 * Version: 1.0.2486
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
