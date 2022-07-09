using System;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            System.Console.WriteLine("Oyun eklendi : " + game.GameName);
        }

        public void Delete(Game game)
        {
            System.Console.WriteLine("Oyun silindi  : " + game.GameName);
        }

        public void Update(Game game)
        {
            System.Console.WriteLine("Oyun güncellendi  : " + game.GameName);
        }
    }
}