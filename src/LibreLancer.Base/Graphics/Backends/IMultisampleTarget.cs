/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:04:50
 * Version: 1.0.2481
 */

namespace LibreLancer.Graphics.Backends;

interface IMultisampleTarget : IRenderTarget
{
    int Width { get; }
    int Height { get; }
    void BlitToScreen(Point offset);
    void BlitToRenderTarget(IRenderTarget2D rTarget);
}
