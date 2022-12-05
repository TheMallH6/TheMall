
using System.Text.Json.Serialization;

namespace TheMall.Data.Modles
{
    public class SessionCredentials
    {
    
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("sessionKey")]
        public string SessionKey{ get; set; }

        [JsonPropertyName("firmID")]
        public int FirmID{ get; set; }



        public SessionCredentials(string role, string sessionKey, int firmID)
        {
            Role = role;
            SessionKey = sessionKey;
            FirmID = firmID;
        }

    }
}
