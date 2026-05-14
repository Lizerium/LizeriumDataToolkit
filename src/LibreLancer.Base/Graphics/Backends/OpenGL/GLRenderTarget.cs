/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 мая 2026 10:38:01
 * Version: 1.0.2475
 */

namespace LibreLancer.Graphics.Backends.OpenGL;

abstract class GLRenderTarget : IRenderTarget
{
    internal abstract void BindFramebuffer();
    public abstract void Dispose();
}
