using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Models;

namespace TradeProject.Abstract
{
    public interface ICampaignService
    {
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
