/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2026 08:32:52
 * Version: 1.0.2585
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
