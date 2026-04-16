/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
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
