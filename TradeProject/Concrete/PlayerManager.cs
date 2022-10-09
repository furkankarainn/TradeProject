using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Abstract;
using TradeProject.Models;

namespace TradeProject.Concrete
{
    public class PlayerManager : IPlayer
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted : " + player.FirstName);
        }

        public void Save(Player player)
        {
            Console.WriteLine("Player saved : " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated : " + player.FirstName);
        }
    }
}
