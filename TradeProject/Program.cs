using System;
using TradeProject.Concrete;
using TradeProject.Models;

namespace TradeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.FirstName = "Furkan";
            Player player1 = new Player { FirstName = "Ömer" };

            PlayerManager playerManager = new PlayerManager();
            //playerManager.Delete(player1);
            //playerManager.Save(player);
            // Buraya kadar oyuncuyu interfaceler yardımıyla crud işlemini yaptık.
            Games games = new Games();
            games.GameName = "Assasin's Creed";
            Games games1 = new Games();
            games1.GameName = "FarCry";
            GameManager gameManager = new GameManager();
            gameManager.Sell(games1, player1);

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Fırsat Günü";

            gameManager.Sell(games1, player1, campaign);
            
        }
    }
}
