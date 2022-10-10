using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Models;

namespace TradeProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
