/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:40
 * Version: 1.0.2449
 */

namespace LibreLancer.Data.Generator
{
    public static class IniHash
    {
        //Case-insensitive hash
        public static uint Hash(string s)
        {
            uint num = 0x811c9dc5;
            for (int i = 0; i < s.Length; i++)
            {
                var c = (int) s[i];
                if ((c >= 65 && c <= 90))
                    c ^= (1 << 5);
                num = ((uint)c ^ num) * 0x1000193;
            }
            return num;
        }
    }
}
