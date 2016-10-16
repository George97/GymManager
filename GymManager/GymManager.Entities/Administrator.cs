namespace GymManager.Entities
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        
    }
}
