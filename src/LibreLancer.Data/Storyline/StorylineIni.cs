/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 октября 2026 10:20:03
 * Version: 1.0.2641
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Storyline;

[ParsedIni]
public partial class StorylineIni
{
    [Section("StoryMission")]
    public List<StoryMission> Missions = new List<StoryMission>();

    [Section("StoryItem")]
    public List<StoryItem> Items = new List<StoryItem>();

    public void AddIni(string path, FileSystem vfs) => ParseIni(path, vfs);

    public void AddDefault()
    {
        using (var stream = typeof(StorylineIni).Assembly.GetManifestResourceStream(
                   "Lizerium.Librelancer.DataBridge.Storyline.Storyline.default.ini"))
        {
            ParseIni(stream, "DefaultStoryline");
        }
    }
}
