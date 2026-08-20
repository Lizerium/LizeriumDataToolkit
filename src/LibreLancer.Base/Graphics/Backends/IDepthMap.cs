/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 августа 2026 09:37:28
 * Version: 1.0.2573
 */

namespace LibreLancer.Graphics.Backends;

public interface IDepthMap : ITexture2D
{
    void BindFramebuffer();
}
