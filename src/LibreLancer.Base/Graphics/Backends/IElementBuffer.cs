/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:59
 * Version: 1.0.2421
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
