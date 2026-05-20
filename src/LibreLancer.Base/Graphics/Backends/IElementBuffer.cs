/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:04:50
 * Version: 1.0.2481
 */

using System;

namespace LibreLancer.Graphics.Backends;

interface IElementBuffer : IDisposable
{
    int IndexCount { get; }
    void SetData(short[] data);
    void SetData(ReadOnlySpan<ushort> data);
    void SetData(ushort[] data, int count, int start = 0);
    void Expand(int newSize);
}
