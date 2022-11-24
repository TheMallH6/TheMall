using System.ComponentModel.DataAnnotations;

namespace TheMall.Data
{
    public class UserLogin
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
