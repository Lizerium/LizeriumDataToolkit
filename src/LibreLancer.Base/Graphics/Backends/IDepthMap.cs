/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июня 2026 06:53:08
 * Version: 1.0.2518
 */

namespace LibreLancer.Graphics.Backends;

public interface IDepthMap : ITexture2D
{
    void BindFramebuffer();
}
