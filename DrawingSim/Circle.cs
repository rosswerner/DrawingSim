using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    //I'm guessing this will need to get modified to inherit from Ellipse in the in-person
    //It could instead be a abstract it out into circle and square being the same shape since they have the same properties?
    internal class Circle : Shape
    {
        public int Size { get; set; }

        private const string ShapeName = "Circle";

        public Circle(int x, int y, int size) : base(x, y)
        {
            if (size < 0) throw new ArgumentException( "Size value must not be negative.");

            Size = size;
        }

        public override string WriteProperties(string? shapeName = null)
        {
            if (String.IsNullOrEmpty(shapeName))
            {
                shapeName = ShapeName;
            }

            string shapeOutput = base.WriteProperties(shapeName);
            return $"{shapeOutput} size={Size}";  }
    }
}

