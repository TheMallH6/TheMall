using System.ComponentModel.DataAnnotations;

namespace TheMall.Data.Modles
{
    public class FirmData
    { 
        public string? Cvr { get; set; }

        public string? Name { get; set; }

        public string? Mallid { get; set; }

        public string? Location { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }

        public string? Firmid { get; set; }


    public FirmData(string? cvr, string? firmname, string? mallid, string? location, string? username, string? password, string? role, string? firmid)
    {
             Cvr = cvr;
            Name = firmname;
            Mallid = mallid;
            Location = location;
            Username = username;
            Password = password;
            Role = role;
            Firmid = firmid;
    }

        public FirmData()
        {

        }
    }
}
