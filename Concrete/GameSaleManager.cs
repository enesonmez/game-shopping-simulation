using System;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            System.Console.WriteLine(game.GameName
                + " isimli oyun "
                + campaign.CampaigneName
                + " adlı kampanya ile "
                + gamer.FirstName
                + " kişisine satıldı.");
        }
    }
}