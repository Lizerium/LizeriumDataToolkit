/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 октября 2026 10:20:03
 * Version: 1.0.2641
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
