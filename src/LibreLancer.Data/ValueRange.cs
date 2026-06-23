/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 июня 2026 15:55:41
 * Version: 1.0.2515
 */

namespace LibreLancer.Data
{
    public record struct ValueRange<T>(T Min, T Max) where T : struct
    {
        public override string ToString() => $"[{Min} -> {Max}]";
    }
}
