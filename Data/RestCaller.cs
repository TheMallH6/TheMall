using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheMall.Data.Modles;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Xml;

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

        public async Task<List<Map>> GetMap(int? mallid)
        {
            if (mallid == null)
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
        /// Get malls from backend database
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
    }
}
