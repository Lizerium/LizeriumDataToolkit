/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июня 2026 06:53:13
 * Version: 1.0.2502
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save;

[ParsedSection]
public partial class MissionDebugState
{
    [Entry("MissionStateNum")]
    public int MissionStateNum;
}
