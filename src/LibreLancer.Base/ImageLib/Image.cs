/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:17:31
 * Version: 1.0.2463
 */

using LibreLancer.Graphics;

namespace LibreLancer.ImageLib;

public class Image
{
    public int Width;
    public int Height;
    public byte[] Data;
    public SurfaceFormat Format = SurfaceFormat.Bgra8;
    public bool Alpha = true;
}
