using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim
{
    internal class Textbox : Rectangle
    {
        public string Text { get; set; }

        private const string ShapeName = "Textbox";

        public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height)
        {
            Text = text;
        }

        public override string WriteProperties(string? shapeName = null)
        {
            if (String.IsNullOrEmpty(shapeName))
            {
                shapeName = ShapeName;
            }

            string shapeOutput = base.WriteProperties(shapeName);
            return $"{shapeOutput} Text=\"{Text}\"";
        }
    }
}
