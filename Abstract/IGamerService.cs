using System;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}