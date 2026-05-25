/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 мая 2026 11:13:35
 * Version: 1.0.2486
 */

namespace LibreLancer.Data
{
    public record struct ValueRange<T>(T Min, T Max) where T : struct
    {
        public override string ToString() => $"[{Min} -> {Max}]";
    }
}
