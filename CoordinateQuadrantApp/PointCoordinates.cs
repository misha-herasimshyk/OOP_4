using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateQuadrantApp
{
    public class PointCoordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointCoordinates(double x, double y)
        {
            X = x;
            Y = y;
        }

       
        public string DetermineQuadrant()
        {
            if (X > 0 && Y > 0) return "у першій чверті";
            else if (X < 0 && Y > 0) return "у другій чверті";
            else if (X < 0 && Y < 0) return "у третій чверті";
            else if (X > 0 && Y < 0) return "у четвертій чверті";
            else if (X == 0 && Y == 0) return "на початку координат";
            else if (X == 0) return "на осі Y";
            else return "на осі X";
        }
    }
}
