using System;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Abstract
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}