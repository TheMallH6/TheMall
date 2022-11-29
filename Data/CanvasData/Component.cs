using System.ComponentModel.DataAnnotations;

namespace TheMall.Data.CanvasData
{
    public class Component
    {
        public int Mapid { get; set; }

        public byte Image { get; set; }

        public string? Description { get; set; }
    }
}

