/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 октября 2026 06:53:15
 * Version: 1.0.2617
 */

namespace LibreLancer.Data
{
    public record struct ValueRange<T>(T Min, T Max) where T : struct
    {
        public override string ToString() => $"[{Min} -> {Max}]";
    }
}
