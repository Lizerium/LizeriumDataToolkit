/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 октября 2026 10:27:37
 * Version: 1.0.2637
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save;

[ParsedSection]
public partial class MissionDebugState
{
    [Entry("MissionStateNum")]
    public int MissionStateNum;
}
