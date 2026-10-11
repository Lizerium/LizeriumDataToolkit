/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2026 11:52:38
 * Version: 1.0.2625
 */

namespace LibreLancer.Graphics.Backends;

public interface IDepthMap : ITexture2D
{
    void BindFramebuffer();
}
