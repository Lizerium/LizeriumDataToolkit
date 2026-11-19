/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2026 07:46:03
 * Version: 1.0.2663
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;

namespace LibreLancer.Platforms
{
	interface IPlatform
    {
        void Init(string sdlBackend);
        string GetLocalConfigFolder();
		bool IsDirCaseSensitive(string directory);
        byte[] GetMonospaceBytes();
        PlatformEvents SubscribeEvents(IUIThread mainThread);

        MountInfo[] GetMounts();

        void Shutdown();
    }
}

