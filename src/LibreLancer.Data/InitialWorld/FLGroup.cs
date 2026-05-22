/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 мая 2026 11:40:54
 * Version: 1.0.2483
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.InitialWorld
{
    [ParsedSection]
    public partial class FlGroup
    {
        [Entry("nickname", Required = true)] public string Nickname;
        [Entry("ids_name")] public int IdsName;
        [Entry("ids_info")] public int IdsInfo;
        [Entry("ids_short_name")] public int IdsShortName;

        public List<GroupReputation> Rep = new List<GroupReputation>();

        [EntryHandler("rep", MinComponents = 2, Multiline = true)]
        void HandleRep(Entry e) =>
            Rep.Add(new GroupReputation(e[0].ToSingle(), e[1].ToString()));
    }

}
