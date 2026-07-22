/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 июля 2026 12:57:03
 * Version: 1.0.2544
 */

namespace LibreLancer.Graphics.Backends.Null;

class NullDepthMap : NullTexture2D, IDepthMap
{
    public NullDepthMap(int width, int height) : base(width, height, false, SurfaceFormat.Depth, 1)
    {
    }

    public void BindFramebuffer()
    {
    }
}
