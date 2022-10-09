using System;
using System.Collections.Generic;
using System.Text;
using TradeProject.Abstract;
using TradeProject.Models;

namespace TradeProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted : " + campaign.CampaignName);
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Campaign saved : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated : " + campaign.CampaignName);
        }
    }
}
