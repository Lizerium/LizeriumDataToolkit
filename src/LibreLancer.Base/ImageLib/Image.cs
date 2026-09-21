/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 сентября 2026 09:35:31
 * Version: 1.0.2605
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
