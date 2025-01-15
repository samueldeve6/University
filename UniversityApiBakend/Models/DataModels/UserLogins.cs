using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace UniversityApiBakend.Models.DataModels
{
    public class UserLogins
    {
        [Required]
        public string UserName { get; set; } 

        [Required]
        public string Password { get; set; }

    }
}
