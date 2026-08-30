/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2026 06:53:27
 * Version: 1.0.2583
 */

using System;
using System.Collections.Generic;

namespace LibreLancer.Data.IO;

public sealed class VfsDirectory : VfsItem
{
    public Dictionary<string, VfsItem> Items = new (StringComparer.OrdinalIgnoreCase);
    public VfsDirectory Parent;
}
