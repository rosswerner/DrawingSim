using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    internal class Rectangle : Shape
    {
        public int Width {get; set;}
        public int Height {get; set;}

        public List<int[]> WidthHeightPairs = new List<int[]>();

        private const string ShapeName = "Rectangle";

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            if (width < 0) throw new ArgumentException("Width value must not be negative.");
            if (height < 0) throw new ArgumentException( "Height value must not be negative.");

            Width = width;
            Height = height;

            WidthHeightPairs.Add( new int[] { width, height } );
        }

        public void EditWidthHeight( int width, int height )
        {
            WidthHeightPairs.Add( new int[] { width, height } );

            Width = width; 
            Height = height;
        }

        public void Undo()
        {
            int[] widthHeightPair = WidthHeightPairs.Last<int[]>();

            WidthHeightPairs.Remove( widthHeightPair );

            widthHeightPair = WidthHeightPairs.Last<int[]>();

            Width = widthHeightPair[0];
            Height = widthHeightPair[1];
        }

        public override string WriteProperties(string? shapeName = null)
        {
            if(String.IsNullOrEmpty(shapeName)) 
            {
                shapeName = ShapeName;
            }

            string shapeOutput = base.WriteProperties(shapeName) ;
            return $"{shapeOutput} width={Width} height={Height}";
        }
    }
}
