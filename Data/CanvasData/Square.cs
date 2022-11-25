using System.Drawing;

namespace TheMall.Data.CanvasData
{
    public class Square
    {
        private Point[] points = new Point[4];

        public Point[] GetPoints
        {
            get { return points; }
        }

        public Square()
        {

        }

        /// <summary>
        /// return true if added
        /// return false if still need more points
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public bool AddPoint(Point newPoint)
        {
            for (int i = 0; i < points.Count(); i++)
            {
                if (!points[i].IsEmpty)
                    continue;
                points[i] = newPoint;
                if (i == 3)
                    return false;
                return true;
            }
            return false;
        }
    }
}
