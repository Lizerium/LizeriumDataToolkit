/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 июня 2026 16:54:15
 * Version: 1.0.2501
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class FlashlightSet
{
    [Entry("icolor")]
    public Color3f IColor;
    [Entry("scale")]
    public float Scale;
    [Entry("gap")]
    public float Gap;
    [Entry("blink")]
    public float Blink;
    [Entry("endpause")]
    public float EndPause;
    [Entry("hardpoint", Multiline = true)]
    public List<string> Hardpoints = new List<string>();
    [Entry("numlights")]
    public int NumLights;
}
