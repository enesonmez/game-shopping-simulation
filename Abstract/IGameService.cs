using System;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}