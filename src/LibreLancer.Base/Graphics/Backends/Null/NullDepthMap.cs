/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:48:41
 * Version: 1.0.2424
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
