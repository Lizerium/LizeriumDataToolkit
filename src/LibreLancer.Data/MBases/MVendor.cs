/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 ноября 2026 06:56:04
 * Version: 1.0.2653
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
