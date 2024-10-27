using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    //I'm guessing this will need to get modified to inherit from Rectangle in the in-person
    internal class Square : Shape
    {
        public int Size { get; set; }

        private const string ShapeName = "Square";

        public Square(int x, int y, int size) : base(x, y)
        {
            if (size < 0) throw new ArgumentException( "Size value must not be negative." );

            Size = size;
        }

        public override string WriteProperties(string? shapeName = null)
        {
            if (String.IsNullOrEmpty(shapeName))
            {
                shapeName = ShapeName;
            }

            string shapeOutput = base.WriteProperties(shapeName);
            return $"{shapeOutput} size={Size}";
        }
    }
}
