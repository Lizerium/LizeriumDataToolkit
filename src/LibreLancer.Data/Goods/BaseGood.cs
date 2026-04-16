/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:44:13
 * Version: 1.0.2437
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Goods
{
    [ParsedSection]
    public partial class BaseGood
    {
        [Entry("base", Required = true)]
        public string Base;

        public List<MarketGood> MarketGoods = new List<MarketGood>();

        [EntryHandler("marketgood", MinComponents = 7, Multiline = true)]
        void HandleMarketGood(Entry e) => MarketGoods.Add(new MarketGood(e));

    }
}
