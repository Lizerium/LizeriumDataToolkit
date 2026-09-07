/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2026 08:17:09
 * Version: 1.0.2591
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
