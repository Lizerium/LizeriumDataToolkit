/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:26:25
 * Version: 1.0.2453
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
