/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 сентября 2026 06:53:25
 * Version: 1.0.2610
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public abstract class PilotBlock
    {
        [Entry("nickname", Required = true)] public string Nickname;
    }
}
