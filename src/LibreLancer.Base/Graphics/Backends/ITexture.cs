/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:39:36
 * Version: 1.0.2429
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
