/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 июля 2026 10:56:50
 * Version: 1.0.2527
 */

using System;

namespace LibreLancer.Graphics.Backends.Null;

class NullElementBuffer : IElementBuffer
{
    public void Dispose()
    {
    }

    public NullElementBuffer(int size) => IndexCount = size;

    public int IndexCount { get; set; }
    public void SetData(short[] data)
    {
    }

    public void SetData(ReadOnlySpan<ushort> data)
    {
    }

    public void SetData(ushort[] data, int count, int start = 0)
    {
    }

    public void Expand(int newSize)
    {
        IndexCount = newSize;
    }
}
