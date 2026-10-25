/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2026 09:05:44
 * Version: 1.0.2638
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