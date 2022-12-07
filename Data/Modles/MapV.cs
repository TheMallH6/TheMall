namespace TheMall.Data.Modles
{
    public class MapV
    {
        /// <summary>
        /// This is the object we are gonna send to the api once a map is ready to be saved
        /// </summary>
        /// <param name="mallId"></param>
        /// <param name="layer"></param>
        /// <param name="components"></param>
        public MapV(int mallId, int layer, List<ComponentV> components)
        {
            MallId = mallId;
            Layer = layer;
            Components = components;
        }

        public int MallId { get; set; }
        public int Layer { get; set; }
        public List<ComponentV> Components { get; set; }
    }
}
