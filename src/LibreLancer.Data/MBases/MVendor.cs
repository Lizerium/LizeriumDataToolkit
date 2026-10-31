/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 октября 2026 10:55:53
 * Version: 1.0.2644
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
