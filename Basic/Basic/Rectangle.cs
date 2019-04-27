using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Rectangle : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw Rectangle({Width}, {Height}");
        }
    }
}
