using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheMall.Data.Modles;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Xml;
using TheMall.Utils;
using System.Security.Cryptography;

namespace TheMall.Data
{
    public class RestCaller
    {
        string apikey = "32d5e8ddd86b49118b19c8c2fdb61cb5";
        string baseUri = "https://localhost:7032/";
        HttpClient client = new HttpClient();

        public RestCaller()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("ApiKey", apikey);
        }

        /// <summary>
        /// Get a list of maps from the database by mallid
        /// </summary>
        /// <param name="mallid"></param>
        /// <returns></returns>
        public async Task<List<Map>> GetMap(int mallid)
        {
            if (mallid == 0)
                return null;
            Uri uri = new Uri(baseUri + "Map/Get?mallid=" + mallid);
            HttpRequestMessage request = CreateaRequestMessage(uri, HttpMethod.Get);
            HttpResponseMessage response = await client.SendAsync(request);
            string responseString = await response.Content.ReadAsStringAsync();
            List<Map> malls = JsonSerializer.Deserialize<List<Map>>(responseString);
            return malls;
        }


        /// <summary>
        /// Create new HttpRequestMessage and set uri and method
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private HttpRequestMessage CreateaRequestMessage(Uri uri, HttpMethod method)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = uri;
            request.Method = method;
            return request;
        }

        /// <summary>
        /// Send map obj to backend to store in database.
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public async Task<string> InsertMap(MapV map)
        {
            Uri uri = new Uri(baseUri + "Map/Create");
            HttpResponseMessage response = await client.PostAsJsonAsync(uri,map);
            string responseString = response.Content.ReadAsStringAsync().Result;
            return responseString;
        }

        /// <summary>
        /// Get all the malls from the database by cvrnr
        /// </summary>
        /// <param name="cvrnr"></param>
        /// <returns></returns>
        public async Task<List<Mall>> GetMalls(int cvrnr)
        {
            Uri uri = new Uri(baseUri + "Mall/GetMalls?cvrnr=" + cvrnr);
            HttpRequestMessage request = CreateaRequestMessage(uri, HttpMethod.Get);
            HttpResponseMessage response = await client.SendAsync(request);
            string responseString = await response.Content.ReadAsStringAsync();
            List<Mall> malls = JsonSerializer.Deserialize<List<Mall>>(responseString);
            return malls;
        }

        /// <summary>
        /// Get sessionCredentials from backend database by validating username and password
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<SessionCredentials> GetLoginCredentiels(string userName, string Password)
        {
            Uri uri = new Uri($"{baseUri}Validate/Login?uname={userName}&password={Password.ToSha256()}");
            var result = await client.PostAsJsonAsync<SessionCredentials>(uri, null);
            var res = result.Content.ReadAsStringAsync().Result;
            SessionCredentials sessionCredentials = JsonSerializer.Deserialize<SessionCredentials>(res);

            return sessionCredentials;
        }

        // Sending Firm objects to API for save in database.
        public async Task<String> InsertFirm(string cvr, string name)
        {
            // Using Uri (Universal Resource Identifier) for calling API and sending objects to API
            Uri uri = new Uri($"{baseUri}Firm/Create?cvr={int.Parse(cvr)}&name={name}");

            // Using HttpResponseMessage for returning a message from API
            HttpResponseMessage response = await client.PostAsJsonAsync<FirmData>(uri, null);

            // Convert JSON value to string
            string responseString = response.Content.ReadAsStringAsync().Result;
            var json = JsonSerializer.Deserialize<string>(responseString);
            return json;

        }

        // Sending Mall objects to API for save in database.
        public async Task<String> InsertMall(string mallid, string location)
        {
            // Using Uri (Universal Resource Identifier) for calling API and sending objects to API
            Uri uri = new Uri($"{baseUri}Mall/Create?firmId={int.Parse(mallid)}&location={location}");

            // Using HttpResponseMessage for returning a message from API
            HttpResponseMessage response = await client.PostAsJsonAsync<FirmData>(uri, null);

            // Convert JSON value to string
            string responseString = response.Content.ReadAsStringAsync().Result;
            var json = JsonSerializer.Deserialize<string>(responseString);
            return json;

        }

        // Sending User objects to API for save in database.
        public async Task<String> InsertUser(string username, string password, string role, string firmid)
        {
            // Using Uri (Universal Resource Identifier) for calling API and sending objects to API
            Uri uri = new Uri($"{baseUri}Validate/Create?uname={username}&password={password}&role={role}&firmid={int.Parse(firmid)}");

            // Using HttpResponseMessage for returning a message from API
            HttpResponseMessage response = await client.PostAsJsonAsync<FirmData>(uri, null);

            // Convert JSON value to string
            string responseString = response.Content.ReadAsStringAsync().Result;
            var json = JsonSerializer.Deserialize<string>(responseString);
            return json;

        }
    }
}
