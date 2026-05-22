/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 мая 2026 11:40:54
 * Version: 1.0.2483
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Solar;

[ParsedSection]
public partial class TextureSection
{
    [Entry("file", Multiline = true)]
    public List<string> Files = new();
}
