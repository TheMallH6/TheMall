namespace TheMall.Data.Modles
{
    public class Mall
    {
        public Mall(int? id, string location)
        {
            this.id = id;
            this.location = location;
        }

        public int? id { get; set; }
        public string location { get; set; }
    }
}
