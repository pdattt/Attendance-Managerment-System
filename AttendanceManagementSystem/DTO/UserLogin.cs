namespace DoAnLapTrinhA.DTO
{
    public class UserLogin
    {
        public string Email { get; }

        public string Password { get; }

        public UserLogin(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}