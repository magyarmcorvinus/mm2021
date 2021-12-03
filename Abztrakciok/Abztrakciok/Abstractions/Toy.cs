using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abztrakciok.Entities
{
    public abstract class Toy: Label
    {
        public Toy()
        {
            AutoSize = false;
            Width = Height = 50;
            Paint += Toy_Paint;
            this.Click += Toy_Click;
        }

        private void Toy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics g);

        public void MoveToy()
        {
            Left = Left + 1;
        }

    }
}
