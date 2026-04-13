/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

using System.Collections.Generic;
using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Universe;

[ParsedSection]
public partial class AsteroidCube
{
    [Entry("xaxis_rotation")]
    public Vector4? RotationX;
    [Entry("yaxis_rotation")]
    public Vector4? RotationY;
    [Entry("zaxis_rotation")]
    public Vector4? RotationZ;

    public List<CubeAsteroid> Cube = new List<CubeAsteroid>();

    [EntryHandler("asteroid", Multiline = true, MinComponents = 7)]
    void HandleAsteroid(Entry e) => Cube.Add(new CubeAsteroid(e));
}
