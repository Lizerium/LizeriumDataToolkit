/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
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
