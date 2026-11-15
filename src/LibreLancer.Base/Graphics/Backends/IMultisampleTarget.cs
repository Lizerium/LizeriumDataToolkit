/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 ноября 2026 11:25:43
 * Version: 1.0.2659
 */

namespace LibreLancer.Graphics.Backends;

interface IMultisampleTarget : IRenderTarget
{
    int Width { get; }
    int Height { get; }
    void BlitToScreen(Point offset);
    void BlitToRenderTarget(IRenderTarget2D rTarget);
}
