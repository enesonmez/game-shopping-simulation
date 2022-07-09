using System;

namespace GameShopppingSimulation.Entity
{
    public class Gamer
    {
        public int Id { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public long IdentityNo { get; set; }
        public DateTime BirthDay { get; set; }
    }
}