/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 мая 2026 13:26:50
 * Version: 1.0.2488
 */

using LibreLancer.Graphics;

namespace LibreLancer;

public interface IGLWindow
{
    RenderContext RenderContext { get; }
    bool IsUiThread();
}
