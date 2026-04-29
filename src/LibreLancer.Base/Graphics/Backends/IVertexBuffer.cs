/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 апреля 2026 06:53:08
 * Version: 1.0.2454
 */

using System;
using LibreLancer.Graphics.Vertices;

namespace LibreLancer.Graphics.Backends;

interface IVertexBuffer : IDisposable
{
    IVertexType VertexType { get; }
    int VertexCount { get; }
    public void SetData<T>(ReadOnlySpan<T> data, int offset = 0) where T : unmanaged;
    void Expand(int newSize);
    void Draw(PrimitiveTypes primitiveType, int baseVertex, int startIndex, int primitiveCount);
    unsafe void DrawImmediateElements(PrimitiveTypes primitiveTypes, int baseVertex, ReadOnlySpan<ushort> elements);
    IntPtr BeginStreaming();
    void EndStreaming(int count);
    void Draw(PrimitiveTypes primitiveType, int primitiveCount);
    void DrawNoApply(PrimitiveTypes primitiveType, int primitiveCount);
    void Draw(PrimitiveTypes primitiveType, int start, int primitiveCount);
    void SetElementBuffer(IElementBuffer elems);
    void UnsetElementBuffer();
}
