namespace API.Entities
{
<<<<<<< HEAD
  public class Users
  {
    public int Id { get; set; }
    public long? UserCode { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public byte[]? PasswordHash { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public int SavedLogin { get; set; } = 0;
    public string? MacNumber { get; set; }
  }
=======
    public class Users
    {
        public int Id { get; set; }
        public long? UserCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int SavedLogin { get; set; } = 0;
        public string MacNumber { get; set; }
    }
>>>>>>> 168439aafcdb12f7110aed5dd5cccf285cd81a2a
}