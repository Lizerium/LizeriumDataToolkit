/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 августа 2026 08:33:31
 * Version: 1.0.2580
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
