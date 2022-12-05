﻿using System.Text.Json.Serialization;

namespace TheMall.Data.Modles
{
    public class GeodataV
    {
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
