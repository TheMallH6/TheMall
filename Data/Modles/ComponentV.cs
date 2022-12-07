namespace TheMall.Data.Modles
{
    public class ComponentV
    {
        /// <summary>
        /// Is used in MapV to store all the diffrent components of the map
        /// </summary>
        /// <param name="description"></param>
        /// <param name="zIndex"></param>
        /// <param name="geodata"></param>
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
