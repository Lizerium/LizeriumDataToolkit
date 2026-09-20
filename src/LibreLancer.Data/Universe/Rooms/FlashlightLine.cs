/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 сентября 2026 08:44:43
 * Version: 1.0.2604
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class FlashlightLine
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
    [Entry("numlights")]
    public int NumLights;
    [Entry("hardpoint", Multiline = true)]
    public List<string> Hardpoints = new List<string>();
}
