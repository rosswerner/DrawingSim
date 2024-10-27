using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            if (x < 0) throw new ArgumentException( "X value must not be negative.");
            if (y < 0) throw new ArgumentException( "Y value must not be negative.");

            X = x;
            Y = y;
        }

        public virtual string WriteProperties(string? shapeName)
        {
            return $"{shapeName} ({X},{Y})";
        }
    }
}
