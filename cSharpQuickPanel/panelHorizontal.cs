using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpQuickPanel
{
    public partial class panelHorizontal : Form
    {
        public panelHorizontal()
        {
            InitializeComponent();
        }

        private void panelHorizontal_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Size = new Size(400, 5);
        }

        Point mouseDownLocation;

        private void ortak_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
            if (this.Height == 5)
            {
                kepenkAc.Start();
                sleepModeActivate.Start();
            }
        }

        Point birinciDeger, ikinciDeger, sonDeger;

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (e.X + this.Left - mouseDownLocation.X);
            }
            birinciDeger = new Point(e.X, e.Y);
        }

        private void sleepModeActivate_Tick(object sender, EventArgs e)
        {
            sonDeger = ikinciDeger;
            ikinciDeger = birinciDeger;
            if (birinciDeger == sonDeger)
            {
                if (this.Height == 150)
                {
                    kepenkKapat.Start();
                }
            }
        }

        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            this.Height += 5;
            if (this.Height == 150)
            {
                kepenkAc.Stop();
            }
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            this.Height -= 5;
            if (this.Height == 5)
            {
                kepenkKapat.Stop();
                sleepModeActivate.Stop();
            }
        }
    }
}
