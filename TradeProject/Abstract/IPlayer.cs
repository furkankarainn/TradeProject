using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Models;

namespace TradeProject.Abstract
{
    public interface IPlayer
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
