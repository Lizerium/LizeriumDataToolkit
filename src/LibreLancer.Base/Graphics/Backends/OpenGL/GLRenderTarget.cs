/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июля 2026 12:19:54
 * Version: 1.0.2529
 */

namespace LibreLancer.Graphics.Backends.OpenGL;

abstract class GLRenderTarget : IRenderTarget
{
    internal abstract void BindFramebuffer();
    public abstract void Dispose();
}
