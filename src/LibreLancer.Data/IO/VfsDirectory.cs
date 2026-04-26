/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 апреля 2026 09:57:02
 * Version: 1.0.2451
 */

using System;
using System.Collections.Generic;

namespace LibreLancer.Data.IO;

public sealed class VfsDirectory : VfsItem
{
    public Dictionary<string, VfsItem> Items = new (StringComparer.OrdinalIgnoreCase);
    public VfsDirectory Parent;
}
