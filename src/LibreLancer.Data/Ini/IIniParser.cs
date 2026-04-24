/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:40
 * Version: 1.0.2449
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
