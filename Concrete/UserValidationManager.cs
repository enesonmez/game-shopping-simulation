using System;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}