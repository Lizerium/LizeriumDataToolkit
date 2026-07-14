/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июля 2026 06:53:44
 * Version: 1.0.2536
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    public abstract class PilotBlock
    {
        [Entry("nickname", Required = true)] public string Nickname;
    }
}
