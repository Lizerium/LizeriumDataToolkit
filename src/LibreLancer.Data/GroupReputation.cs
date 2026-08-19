/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 августа 2026 10:23:12
 * Version: 1.0.2572
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