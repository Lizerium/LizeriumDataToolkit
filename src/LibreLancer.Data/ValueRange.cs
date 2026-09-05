/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2026 08:37:05
 * Version: 1.0.2589
 */

namespace LibreLancer.Data
{
    public record struct ValueRange<T>(T Min, T Max) where T : struct
    {
        public override string ToString() => $"[{Min} -> {Max}]";
    }
}
