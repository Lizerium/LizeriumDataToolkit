/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:32:28
 * Version: 1.0.2428
 */

using System;
namespace LibreLancer
{
    internal unsafe class FNV1A
    {
        public static int Hash(IntPtr input, int sz, int startHash = -2128831035)
        {
            var bytes = (byte*) input;
            unchecked
            {
                uint hash = (uint) startHash;
                for (int i = 0; i < sz; i++)
                    hash = (hash ^ bytes[i]) * 16777619;
                return (int) hash;
            }
        }

        public static int Hash(string s, int startHash = -2128831035)
        {
            uint hash = (uint) startHash;
            for (int i = 0; i < s.Length; i++)
                hash = (hash ^ s[i]) * 16777619;
            return (int) hash;
        }
    }
}