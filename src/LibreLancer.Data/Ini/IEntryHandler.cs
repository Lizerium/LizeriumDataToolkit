/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 июня 2026 06:53:00
 * Version: 1.0.2512
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

namespace LibreLancer.Data.Ini
{
    public interface IEntryHandler
    {
        bool HandleEntry(Entry e);
    }
}
