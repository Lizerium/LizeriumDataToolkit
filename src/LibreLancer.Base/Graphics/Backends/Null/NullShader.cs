/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:27:48
 * Version: 1.0.2426
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
