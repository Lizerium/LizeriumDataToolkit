/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Save
{
    [ParsedSection]
    public partial class SaveTime : IWriteSection
    {
        [Entry("seconds")]
        public float Seconds;

        public void WriteTo(IniBuilder builder)
        {
            builder.Section("Time")
                .Entry("seconds", Seconds);
        }
    }
}
