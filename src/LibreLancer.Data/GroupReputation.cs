/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 августа 2026 06:53:19
 * Version: 1.0.2564
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