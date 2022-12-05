using System.ComponentModel.DataAnnotations;

namespace TheMall.Data.Modles
{
    public class FirmUser
    {

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }


        public FirmUser(string? userName, string? password)
        {
            UserName = userName;
            Password = password;
        }

        public FirmUser()
        {

        }
    }
}
