/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2026 09:42:09
 * Version: 1.0.2607
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
