namespace ToDoListAPI.Helpers.TokenSettings
{
    public class JwtSettings
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double ExpireOn { get; set; }
        public string SecretKey { get; set; }


    }
}
