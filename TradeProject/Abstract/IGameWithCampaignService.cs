using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Models;

namespace TradeProject.Abstract
{
    public interface IGameWithCampaignService
    {
        void Sell(Games games, Player player, Campaign campaign);
    }
}
