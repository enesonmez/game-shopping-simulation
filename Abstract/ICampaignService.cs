using System;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}