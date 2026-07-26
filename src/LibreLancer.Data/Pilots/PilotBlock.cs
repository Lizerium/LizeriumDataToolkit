/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июля 2026 15:12:08
 * Version: 1.0.2548
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public abstract class PilotBlock
    {
        [Entry("nickname", Required = true)] public string Nickname;
    }
}
