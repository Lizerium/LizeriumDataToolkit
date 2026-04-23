/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:53:35
 * Version: 1.0.2448
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
