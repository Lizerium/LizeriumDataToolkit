/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 ноября 2026 06:52:35
 * Version: 1.0.2662
 */

using System;

namespace LibreLancer.Graphics.Backends;

public interface ITexture : IDisposable
{
    SurfaceFormat Format { get; }
    int EstimatedTextureMemory { get; }
    int LevelCount { get; }
    bool IsDisposed { get; }

    void BindTo(int unit);
}
