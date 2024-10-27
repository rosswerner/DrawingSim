using System;
using System.Drawing;

namespace DrawingSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>() { };
            // Add widgets here:
            //rectangle x = 10, y = 10, width = 30 height = 40
            shapes.Add(new Rectangle(10, 10, 30, 40));
            //square x = 15, y = 30, size = 35
            shapes.Add(new Square(15, 30, 35));
            //ellipse x = 100, y = 150, horizontal diameter = 300, vertical diameter = 200
            shapes.Add(new Ellipse(100, 150, 300, 200));
            //circle x = 1, y = 1, size = 300
            shapes.Add(new Circle(1, 1, 300));
            //textbox x = 5, y = 5, width = 200, height = 100, text = "sample text"
            shapes.Add(new Textbox(5, 5, 200, 100, "sample text"));

            Output(shapes);

            //Console.WriteLine( "Press Enter to exit..." );
            Console.ReadLine();
        }

        static int Output(List<Shape> shapes)
        {
            Console.WriteLine("----------------------------------------------------------------\r\nRequested Drawing\r\n----------------------------------------------------------------");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.WriteProperties(null));
            }
            Console.WriteLine("----------------------------------------------------------------");
            return 0;
        }
    }
}