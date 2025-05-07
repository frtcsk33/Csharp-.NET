using CodeFirst3.Enums;

namespace CodeFirst3.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
