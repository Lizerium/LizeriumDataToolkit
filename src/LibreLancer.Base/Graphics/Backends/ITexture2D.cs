/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
 */

using System;
using System.Threading.Tasks;

namespace LibreLancer.Graphics.Backends;

public interface ITexture2D : ITexture
{
    int Width { get; }
    int Height { get; }
    void SetFiltering(TextureFiltering filtering);
    Task<byte[]> GetDataAsync();
    void GetData<T>(int level, Rectangle? rect, T[] data, int start, int count) where T : struct;
    void GetData<T>(T[] data) where T : struct;
    void SetData<T>(int level, Rectangle? rect, T[] data, int start, int count) where T : unmanaged;
    void SetWrapModeS(WrapMode mode);
    void SetWrapModeT(WrapMode mode);
    void SetData(int level, Rectangle rect, IntPtr data);
    void SetData<T>(T[] data) where T : unmanaged;

    bool Dxt1 { get;  }
}
