/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июля 2026 08:36:47
 * Version: 1.0.2523
 */

namespace LibreLancer.Data
{ 
    public struct GroupReputation
    {
        public float Rep;
        public string Name;

        public GroupReputation(float rep, string name)
        {
            Rep = rep;
            Name = name;
        }
    }
}