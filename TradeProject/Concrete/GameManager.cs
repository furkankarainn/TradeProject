using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Abstract;
using TradeProject.Models;

namespace TradeProject.Concrete
{
    class GameManager : IGameService, IGameWithCampaignService
    {
        public void Sell(Games games, Player player)
        {
            Console.WriteLine(games.GameName + " that game sold to " + player.FirstName);
        }

        public void Sell(Games games, Player player, Campaign campaign)
        {
            Console.WriteLine(games.GameName + " that game sold to " + player.FirstName + " with this campaign " + campaign.CampaignName);
        }
    }
}
