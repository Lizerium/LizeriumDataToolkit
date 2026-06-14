/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июня 2026 16:36:05
 * Version: 1.0.2506
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
