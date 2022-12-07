namespace TheMall.Data.Modles
{
    public class Mall
    {
        /// <summary>
        /// This object is what we are getting when we are asking for malls from the api
        /// </summary>
        /// <param name="id"></param>
        /// <param name="location"></param>
        public Mall(int? id, string location)
        {
            this.id = id;
            this.location = location;
        }

        public int? id { get; set; }
        public string location { get; set; }
    }
}
