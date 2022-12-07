namespace TheMall.Data.Modles
{
    public class Map
    {
        /// <summary>
        /// This is the object we get from the api when, when we ask for a map
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="components"></param>
        public Map(int layer, Dictionary<string, object> components)
        {
            this.layer = layer;
            this.components = components;
        }

        public int layer { get; set; }
        public Dictionary<string,object> components { get; set; }
    }
}
