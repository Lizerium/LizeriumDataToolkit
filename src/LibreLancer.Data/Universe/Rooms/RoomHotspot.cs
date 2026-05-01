/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 мая 2026 06:53:12
 * Version: 1.0.2456
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
