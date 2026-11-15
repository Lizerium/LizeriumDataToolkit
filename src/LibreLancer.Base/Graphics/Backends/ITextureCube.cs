/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 ноября 2026 11:25:43
 * Version: 1.0.2659
 */

namespace LibreLancer.Graphics.Backends;

public interface ITextureCube : ITexture
{
    int Size { get; }
    void SetData<T>(CubeMapFace face, int level, Rectangle? rect, T[] data, int start, int count) where T : unmanaged;
    void SetData<T>(CubeMapFace face, T[] data) where T : unmanaged;
    void SetFiltering(TextureFiltering filtering);
}
