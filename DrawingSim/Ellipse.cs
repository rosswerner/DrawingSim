using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    internal class Ellipse : Shape
    {
        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        private const string ShapeName = "Ellipse";

    public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
        {
            if (horizontalDiameter < 0) throw new ArgumentException( "Horizontal Diameter value must not be negative.");
            if (verticalDiameter < 0) throw new ArgumentException( "Vertical Diameter value must not be negative.");

            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override string WriteProperties(string? shapeName = null)
        {
            if (String.IsNullOrEmpty(shapeName))
            {
                shapeName = ShapeName;
            }

            string shapeOutput = base.WriteProperties(shapeName);
            //Extra spaces in the write here as per sample output
            return $"{shapeOutput} diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
        }
    }
}
