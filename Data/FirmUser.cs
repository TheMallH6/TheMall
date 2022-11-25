using System.ComponentModel.DataAnnotations;

namespace TheMall.Data
{
    public class FirmUser
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        public string? Role { get; set; }

        public string? SessionKey { get; set; }

        public int FirmID { get; set; }


    }
}
