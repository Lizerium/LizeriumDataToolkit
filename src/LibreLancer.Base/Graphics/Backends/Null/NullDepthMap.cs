/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июля 2026 10:11:00
 * Version: 1.0.2550
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
