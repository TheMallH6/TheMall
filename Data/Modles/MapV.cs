namespace TheMall.Data.Modles
{
    public class MapV
    {
        public MapV(int? mallId, int layer, List<ComponentV> components)
        {
            MallId = mallId;
            Layer = layer;
            Components = components;
        }

        public int? MallId { get; set; }
        public int Layer { get; set; }
        public List<ComponentV> Components { get; set; }
    }
}
