using System;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}