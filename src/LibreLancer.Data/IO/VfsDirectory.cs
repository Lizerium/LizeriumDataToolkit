/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2026 07:39:59
 * Version: 1.0.2588
 */

using System;
using System.Collections.Generic;

namespace LibreLancer.Data.IO;

public sealed class VfsDirectory : VfsItem
{
    public Dictionary<string, VfsItem> Items = new (StringComparer.OrdinalIgnoreCase);
    public VfsDirectory Parent;
}
