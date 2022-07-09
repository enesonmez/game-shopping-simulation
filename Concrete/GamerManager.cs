using System;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        // Constructure injection
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                System.Console.WriteLine("Oyuncu kayıt edildi : " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                System.Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            System.Console.WriteLine("Oyuncu silindi : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            System.Console.WriteLine("Oyuncu güncellendi : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}