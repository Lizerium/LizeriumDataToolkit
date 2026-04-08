/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:27:48
 * Version: 1.0.2426
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class SystemBackground
{
    [Entry("basic_stars")]
    public string BasicStarsPath;
    [Entry("complex_stars")]
    public string ComplexStarsPath;
    [Entry("nebulae")]
    public string NebulaePath;
}
