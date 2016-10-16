namespace GymManager.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CardNumber { get; set; }
        public int AdminId { get; set; }
        public int Price { get; set; }
        public int Validaty { get; set; }
        public string CardType { get; set; }
    }
}
