namespace ToDoListAPI.Models.CustomModels
{
    public class AuthResponse
    {
        public string? Massage { get; set; }
        public bool IsAuthenticated { get; set; }
        public string? Token { get; set; }
        public DateTime ExpireOn { get; set; }
        

    }
}
