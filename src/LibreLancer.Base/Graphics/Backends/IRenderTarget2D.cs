/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:17:31
 * Version: 1.0.2463
 */

namespace LibreLancer.Graphics.Backends;

interface IRenderTarget2D : IRenderTarget
{
    void BlitToScreen();
    void BlitToBuffer(RenderTarget2D other, Point offset);
    void BlitToScreen(Point offset);
    int Width { get; }
    int Height { get; }
}
