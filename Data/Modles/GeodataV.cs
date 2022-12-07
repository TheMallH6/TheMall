using System.Text.Json.Serialization;

namespace TheMall.Data.Modles
{
    public class GeodataV
    {
        /// <summary>
        /// Used in ComponentV to store the the spatial data we use to draw on the map
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xInput"></param>
        /// <param name="yInput"></param>
        /// <param name="srid"></param>
        public GeodataV(string type, int[] xInput, int[] yInput, int srid)
        {
            Type = type;
            XInput = xInput;
            YInput = yInput;
            Srid = srid;
        }
        public string Type { get; set; }
        public int[] XInput { get; set; }
        public int[] YInput { get; set; }
        public int Srid { get; set; }
    }
}
