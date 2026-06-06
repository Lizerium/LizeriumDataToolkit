/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:48:39
 * Version: 1.0.2498
 */

namespace LibreLancer.Graphics.Backends;

public interface IDepthMap : ITexture2D
{
    void BindFramebuffer();
}
