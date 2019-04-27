using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class MyPaint
    {
        List<IDrawable> shapes = new List<IDrawable>();

        public void DrawShape(IDrawable shape)
        {
            shapes.Add(shape);

            foreach(IDrawable s in shapes)
            {
                s.Draw();
            }
        }
    }
}
