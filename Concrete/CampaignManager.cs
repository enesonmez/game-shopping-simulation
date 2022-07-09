using System;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            System.Console.WriteLine("Kampanya eklendi : " + campaign.CampaigneName);
        }

        public void Delete(Campaign campaign)
        {
            System.Console.WriteLine("Kampanya silindi  : " + campaign.CampaigneName);
        }

        public void Update(Campaign campaign)
        {
            System.Console.WriteLine("Kampanya güncellendi  : " + campaign.CampaigneName);
        }
    }
}