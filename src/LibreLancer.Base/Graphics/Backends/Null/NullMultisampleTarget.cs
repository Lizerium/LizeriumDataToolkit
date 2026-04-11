/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:39:36
 * Version: 1.0.2429
 */

namespace LibreLancer.Graphics.Backends.Null;

class NullMultisampleTarget : IMultisampleTarget
{
    public NullMultisampleTarget(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void Dispose()
    {
    }

    public int Width { get; }
    public int Height { get; }
    public void BlitToScreen(Point offset)
    {
    }

    public void BlitToRenderTarget(IRenderTarget2D rTarget)
    {
    }
}
