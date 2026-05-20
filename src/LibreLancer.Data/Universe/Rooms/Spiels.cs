/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:04:50
 * Version: 1.0.2481
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class Spiels
{
    [Entry("EquipmentDealer")]
    public string EquipmentDealer;
    [Entry("ShipDealer")]
    public string ShipDealer;
    [Entry("CommodityDealer")]
    public string CommodityDealer;
}
