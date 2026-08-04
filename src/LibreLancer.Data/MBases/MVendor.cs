/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 августа 2026 06:53:45
 * Version: 1.0.2557
 */

using System.Numerics;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

[ParsedSection]
public partial class MVendor
{
    [Entry("num_offers")]
    public Vector2 NumOffers;
}
