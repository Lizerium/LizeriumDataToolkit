/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 августа 2026 06:53:20
 * Version: 1.0.2561
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
