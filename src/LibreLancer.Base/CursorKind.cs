/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:59:25
 * Version: 1.0.2422
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
namespace LibreLancer
{
    public enum CursorKind
    {
        Arrow,
        TextInput,
        Move,
        ResizeNS,
        ResizeEW,
        ResizeNESW,
        ResizeNWSE,
        NotAllowed,
        None
    }
}
