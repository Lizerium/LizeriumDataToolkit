/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 мая 2026 14:55:54
 * Version: 1.0.2492
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System.Collections.Generic;
using System.IO;

namespace LibreLancer.Data.Ini
{
    public interface IIniParser
    {
        bool CanParse(Stream stream);

        IEnumerable<Section> ParseIniFile(string path, Stream stream, bool preparse = true, bool allowmaps = false);

    }
}
