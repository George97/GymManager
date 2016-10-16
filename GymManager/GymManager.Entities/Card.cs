using System;

namespace GymManager.Entities
{
    public class Card
    {
        public int CardNumber { get; set; }
        public  string TypeCard { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public int AdminId { get; set; }
        public int Month{ get; set; }
    }
}
