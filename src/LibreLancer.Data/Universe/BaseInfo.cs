/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 ноября 2026 10:48:59
 * Version: 1.0.2670
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class BaseInfo
{
    [Entry("nickname")] public string Nickname;
    [Entry("start_room")] public string StartRoom;
    [Entry("price_variance")] public float PriceVariance;
}
