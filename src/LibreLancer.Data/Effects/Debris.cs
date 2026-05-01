/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 мая 2026 06:53:12
 * Version: 1.0.2456
 */

using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Effects;

[ParsedSection]
public partial class Debris
{
    [Entry("nickname", Required = true)] public string Nickname;
    [Entry("death_method")] public string DeathMethod;
    [Entry("lifetime")] public ValueRange<float> Lifetime;
    [Entry("linear_drag")] public float LinearDrag;
    [Entry("angular_drag")] public Vector3 AngularDrag;
    [Entry("rotation_inertia")] public Vector3 RotationInertia;
    [Entry("trail")] public string Trail;
    [Entry("explosion")] public string Explosion;
}
