using System.ComponentModel.DataAnnotations;

namespace VInternshipWebApp.Models
{
    public class Registration
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }
    }
}
