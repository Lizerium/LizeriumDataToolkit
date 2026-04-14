/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:25:20
 * Version: 1.0.2432
 */

using System;

namespace LibreLancer.Graphics.Backends;

interface IStorageBuffer : IDisposable
{
    int GetAlignedIndex(int input);
    void SetData<T>(T[] array, int start = 0, int length = -1) where T : unmanaged;
    void SetData<T>(ref T item, int index = 0) where T : unmanaged;
    void BindTo(int binding, int start = 0, int count = 0);
    ref T Data<T>(int i) where T : unmanaged;
    IntPtr BeginStreaming();
    void EndStreaming(int count);
}
