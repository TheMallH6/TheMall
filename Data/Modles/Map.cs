namespace TheMall.Data.Modles
{
    public class Map
    {
        public Map(int mallId, int layer, List<Component> components)
        {
            MallId = mallId;
            Layer = layer;
            Components = components;
        }

        public int MallId { get; set; }
        public int Layer { get; set; }
        public List<Component> Components { get; set; }
    }
}
