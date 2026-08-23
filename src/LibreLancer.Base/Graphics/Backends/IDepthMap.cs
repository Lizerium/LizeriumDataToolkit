/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 августа 2026 06:53:25
 * Version: 1.0.2576
 */

namespace LibreLancer.Graphics.Backends;

public interface IDepthMap : ITexture2D
{
    void BindFramebuffer();
}
