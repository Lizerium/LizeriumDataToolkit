/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:17:31
 * Version: 1.0.2463
 */

using System;
using System.Numerics;

namespace LibreLancer.Graphics.Backends.Null;

class NullShader : IShader
{
    public void SetUniformBlock<T>(int index, ref T data,  bool forceUpdate = false, int forceSize = -1) where T : unmanaged
    {
    }

    public bool HasUniformBlock(int index)
    {
        return false;
    }

    public ref ulong UniformBlockTag(int index)
    {
        throw new IndexOutOfRangeException();
    }
}
