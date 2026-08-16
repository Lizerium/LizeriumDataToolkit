/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:25:32
 * Version: 1.0.2569
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
