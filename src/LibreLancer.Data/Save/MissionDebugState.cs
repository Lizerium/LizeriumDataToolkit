/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июля 2026 10:11:00
 * Version: 1.0.2550
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save;

[ParsedSection]
public partial class MissionDebugState
{
    [Entry("MissionStateNum")]
    public int MissionStateNum;
}
