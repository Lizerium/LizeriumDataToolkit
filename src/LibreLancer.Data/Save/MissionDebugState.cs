/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 октября 2026 06:53:25
 * Version: 1.0.2624
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save;

[ParsedSection]
public partial class MissionDebugState
{
    [Entry("MissionStateNum")]
    public int MissionStateNum;
}
