/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 мая 2026 11:40:54
 * Version: 1.0.2483
 */

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class RoomSound
{
    public string Music;
    public bool MusicOneShot;
    [Entry("ambient")]
    public string Ambient;

    [EntryHandler("music", MinComponents = 1)]
    void MusicEntry(Entry e)
    {
        Music = e[0].ToString();
        MusicOneShot = e.Count > 1 && e[1].ToString().Equals("oneshot", StringComparison.OrdinalIgnoreCase);
    }
}
