/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:04:25
 * Version: 1.0.2423
 */

using LibreLancer.Graphics;

namespace LibreLancer;

public interface IGLWindow
{
    RenderContext RenderContext { get; }
    bool IsUiThread();
}
