using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abztrakciok.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imagefile = Image.FromFile("car.png");
            g.DrawImage(imagefile, new Rectangle(0, 0, Width, Height));
        }
    }
}
