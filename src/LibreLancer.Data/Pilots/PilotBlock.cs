/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2026 07:37:52
 * Version: 1.0.2599
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public abstract class PilotBlock
    {
        [Entry("nickname", Required = true)] public string Nickname;
    }
}
