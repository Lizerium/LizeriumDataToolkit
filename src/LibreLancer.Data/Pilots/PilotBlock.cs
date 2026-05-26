/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 мая 2026 11:44:01
 * Version: 1.0.2487
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public abstract class PilotBlock
    {
        [Entry("nickname", Required = true)] public string Nickname;
    }
}
