/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 мая 2026 13:26:50
 * Version: 1.0.2488
 */

using System;
using System.Numerics;

namespace LibreLancer.Graphics.Backends;

interface IShader
{
    void SetUniformBlock<T>(int index, ref T data, bool forceUpdate = false, int forceSize = -1) where T : unmanaged;
    bool HasUniformBlock(int index);
    ref ulong UniformBlockTag(int index);
}
