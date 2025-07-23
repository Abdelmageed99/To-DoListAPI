using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models.DomainModels.UserManagement.DTO
{
    public class RegisterModel
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public string FullName => FName + " " + LName;

        [EmailAddress]
        public string Email { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }
    }

}
