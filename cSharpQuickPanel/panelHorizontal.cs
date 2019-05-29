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
            this.Opacity = 0.50;
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

        Point saniye5, saniye4, saniye3, saniye2, saniye1;

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (e.X + this.Left - mouseDownLocation.X);
            }
            saniye1 = new Point(e.X, e.Y);
        }

        private void sleepModeActivate_Tick(object sender, EventArgs e)
        {
            saniye5 = saniye4;
            saniye4 = saniye3;
            saniye3 = saniye2;
            saniye2 = saniye1;
            if (saniye1 == saniye5)
            {
                if (this.Height == 150)
                {
                    kepenkKapat.Start();
                }
            }
            else
            {
                if (Cursor.Position.X < this.Left || Cursor.Position.X > (this.Left + this.Width) || Cursor.Position.Y < this.Top || Cursor.Position.Y > (this.Top + this.Height))
                {
                    if (this.Height == 150)
                    {
                        kepenkKapat.Start();
                    }
                }
            }
        }

        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            this.Height += 5;
            if(this.Opacity<1)
            {
                this.Opacity += 0.05;
            }
            if (this.Height == 150)
            {
                kepenkAc.Stop();
            }
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            this.Height -= 5;
            if (this.Opacity > 0.50)
            {
                this.Opacity -= 0.05;
            }
            if (this.Height == 5)
            {
                kepenkKapat.Stop();
                sleepModeActivate.Stop();
            }
        }
    }
}
