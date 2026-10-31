/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 октября 2026 10:55:53
 * Version: 1.0.2644
 */

using LibreLancer.Graphics;

namespace LibreLancer;

public interface IGLWindow
{
    RenderContext RenderContext { get; }
    bool IsUiThread();
}
