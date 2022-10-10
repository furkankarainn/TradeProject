using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Abstract;
using TradeProject.Models;

namespace TradeProject.Concrete
{
    public class PlayerManager : IPlayer
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Player player)
        {

            Console.WriteLine("Player deleted : " + player.FirstName);
        }

        public void Save(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine("Player saved : " + player.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated : " + player.FirstName);
        }
    }
}
