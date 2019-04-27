using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class CustomShape : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public CustomShape(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw CustomShape ({Width}, {Height}, {X}, {Y}");
        }
    }
}
