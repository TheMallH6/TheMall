namespace TheMall.Data.Modles
{
    public class Map
    {
        public Map(int layer, Dictionary<string, object> components)
        {
            this.layer = layer;
            this.components = components;
        }

        public int layer { get; set; }
        public Dictionary<string,object> components { get; set; }
    }
}
