using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abztrakciok.Entities
{
    public class Ball: Toy
    {
        public SolidBrush BallColor { get; private set; }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width/2, Height/2);
        }

        public Ball(Color c)
        {
            BallColor = new SolidBrush(c);
            this.Click += Ball_Click;

        }


        private void Ball_Click(object sender, EventArgs e)
        {
            BallColor = new SolidBrush(Color.White);
            Invalidate();
        }

        public new void MoveToy()
        {
            base.MoveToy();
            //ameddig nem nulla addig csökkenjen, 
            if (this.Top < 100) this.Top++;
        }

    }
}
