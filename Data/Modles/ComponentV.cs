namespace TheMall.Data.Modles
{
    public class ComponentV
    {
        public ComponentV(string description, int zIndex, GeodataV geodata)
        {
            Description = description;
            ZIndex = zIndex;
            Geodata = geodata;
        }

        public string Description { get; set; }
        public int ZIndex { get; set; }
        public GeodataV Geodata { get; set; }
    }
}
