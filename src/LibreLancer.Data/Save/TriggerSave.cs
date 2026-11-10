/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 ноября 2026 11:43:48
 * Version: 1.0.2654
 */

using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save;

[ParsedSection]
public partial class TriggerSave : IWriteSection
{
    [Entry("trigger")]
    public int Trigger;

    public void WriteTo(IniBuilder builder)
    {
        builder.Section("TriggerSave")
            .Entry("trigger", (uint)Trigger);
    }
}
