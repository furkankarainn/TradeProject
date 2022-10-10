using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Abstract;
using TradeProject.Models;

namespace TradeProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 1997 && player.FirstName == "Furkan" && player.LastName == "Karain" && player.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
