namespace TheMall.Data.Modles
{
    public class Component
    {
        public Component(string description, int zIndex, Geodata geodata)
        {
            Description = description;
            ZIndex = zIndex;
            Geodata = geodata;
        }

        public string Description { get; set; }
        public int ZIndex { get; set; }
        public Geodata Geodata { get; set; }
    }
}
