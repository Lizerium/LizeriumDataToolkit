/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 ноября 2026 13:31:03
 * Version: 1.0.2652
 */

namespace LibreLancer.Graphics.Backends.OpenGL;

abstract class GLRenderTarget : IRenderTarget
{
    internal abstract void BindFramebuffer();
    public abstract void Dispose();
}
