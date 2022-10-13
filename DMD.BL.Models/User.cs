namespace DMD.BL.Models
{
    public class User
    {
        public Guid Id { get; set; } // use guids instead of integers for the Id
        public string UserName { get; set; }
        public string Password { get; set; } //todo: Make sure this is hashed later.
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        //public string? Address { get; set; }
    }
}