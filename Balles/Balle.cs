using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles
{
    class Balle : PictureBox
    {
        Timer tm = new Timer();
        Int32 vitesseX;
        Int32 vitesseY;

        //public Int32 VitesseX { get; set; }
        //public Int32 VitesseY { get; set; }

        public Balle() : base()
        {
        }

        public Balle(Timer tm) : base()
        {
            this.tm = tm;
            //this.vitesseX = vitesseX;
            //this.vitesseY = vitesseY;
        }

        public void lancer(int vitesseX, int vitesseY)
        {
            this.vitesseX = vitesseX;
            this.vitesseY = vitesseY;
            tm.Interval = 8;
            tm.Tick += bouger;
            tm.Enabled = true;
        }     

        private void bouger(Object sender, EventArgs e)
        {
            if (this.Left < 0) { vitesseX = -vitesseX; }
            if (this.Left > FindForm().Width - this.Width - 15) { vitesseX = -vitesseX; }
            if (this.Top < 0) { vitesseY = -vitesseY; }
            if (this.Top > FindForm().Height - this.Height - 38) { vitesseY = -vitesseY; }
            this.Left = this.Left + vitesseX;
            this.Top = this.Top + vitesseY;
        }
    }
}
