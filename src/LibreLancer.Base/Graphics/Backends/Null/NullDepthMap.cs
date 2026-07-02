/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 июля 2026 07:15:12
 * Version: 1.0.2524
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
