/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июня 2026 16:36:05
 * Version: 1.0.2506
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
