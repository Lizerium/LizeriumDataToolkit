/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 мая 2026 13:26:50
 * Version: 1.0.2488
 */

namespace LibreLancer.Graphics.Backends;

interface IMultisampleTarget : IRenderTarget
{
    int Width { get; }
    int Height { get; }
    void BlitToScreen(Point offset);
    void BlitToRenderTarget(IRenderTarget2D rTarget);
}
