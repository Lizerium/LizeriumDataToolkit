/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июля 2026 13:35:35
 * Version: 1.0.2528
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
