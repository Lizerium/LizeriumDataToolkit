/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 июня 2026 06:53:22
 * Version: 1.0.2504
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
