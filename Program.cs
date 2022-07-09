using System;
using GameShopppingSimulation.Concrete;
using GameShopppingSimulation.Entity;

namespace GameShopppingSimulation 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer enes = new Gamer
            {
                Id=1,
                FirstName="ENES",
                LastName="SÖNMEZ",
                IdentityNo=22222222222,
                BirthDay=new DateTime(1999,11,12)
            };

            GamerManager gamerManager = new GamerManager(new MernisUserValidation());
            gamerManager.Add(enes);
            gamerManager.Update(enes);
            gamerManager.Delete(enes);

            Game fifa = new Game{Id=1, GameName="FIFA22"};
            GameManager gameManager = new GameManager();
            gameManager.Add(fifa);
            gameManager.Update(fifa);
            gameManager.Delete(fifa);

            Campaign noDiscount = new Campaign{Id=1,CampaigneName="indirimsiz"};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(noDiscount);
            campaignManager.Update(noDiscount);
            campaignManager.Delete(noDiscount);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(enes,fifa,noDiscount);
            
        }
    }
}