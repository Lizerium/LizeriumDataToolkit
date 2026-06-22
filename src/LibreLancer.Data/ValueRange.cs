/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 июня 2026 06:53:25
 * Version: 1.0.2514
 */

namespace LibreLancer.Data
{
    public record struct ValueRange<T>(T Min, T Max) where T : struct
    {
        public override string ToString() => $"[{Min} -> {Max}]";
    }
}
