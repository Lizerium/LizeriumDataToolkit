/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:25:20
 * Version: 1.0.2432
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe.Rooms;

[ParsedSection]
public partial class RoomHotspot
{
    [Entry("name")]
    public string Name;
    [Entry("behavior")]
    public string Behavior;
    [Entry("room_switch")]
    public string RoomSwitch;
    [Entry("set_virtual_room")]
    public string SetVirtualRoom;
    [Entry("virtual_room")]
    public string VirtualRoom;
    [Entry("state_read")]
    public int StateRead;
    [Entry("state_send")]
    public int StateSend;
}
