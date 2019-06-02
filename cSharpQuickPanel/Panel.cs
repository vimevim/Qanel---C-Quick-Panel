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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        public void Panel_Load(object sender, EventArgs e)
        {           
            this.Width = 5;
            Changes();

        }
        public void Changes()
        {
            this.Height = ayarlar.Default.size;
            this.Visible = ayarlar.Default.visibility;
            this.Opacity = ayarlar.Default.opacity;
            this.BackColor = ayarlar.Default.renk;
            if(ayarlar.Default.panelMod=="left")
            {
                this.Left = 0;
                dots2.Left = 30;
                dots1.Left = 30;
                panel2.Left = 120;
                panel1.Left = 117;
            }
            else if(ayarlar.Default.panelMod=="right")
            {
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                dots2.Left = 58;
                dots1.Left = 58;
                panel2.Left = 0;
                panel1.Left = 30;
            }
        }
        Point mouseDownLocation;

        private void ortak_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
            if (this.Width == 5)
            {
                kepenkAc.Start();
                sleepModeActivate.Start();
            }
        }

        Point saniye5, saniye4, saniye3, saniye2, saniye1;

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = (e.Y + this.Top - mouseDownLocation.Y);
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
                if (this.Width == 150)
                {
                    kepenkKapat.Start();
                }
            }
            else
            {
                if (Cursor.Position.X < this.Left || Cursor.Position.X > (this.Left + this.Width) || Cursor.Position.Y < this.Top || Cursor.Position.Y > (this.Top + this.Height))
                {
                    if (this.Width == 150)
                    {
                        kepenkKapat.Start();
                    }
                }
            }
        }


        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            this.Width += 5;
            if(ayarlar.Default.panelMod=="right")
            {
                this.Left -= 5;
            }
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            if (this.Width == 150)
            {
                kepenkAc.Stop();
            }
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            this.Width -= 5;
            if(ayarlar.Default.panelMod=="right")
            {
                this.Left += 5;
            }
            if (this.Opacity > ayarlar.Default.opacity)
            {
                this.Opacity -= 0.05;
            }
            if (this.Width == 5)
            {
                kepenkKapat.Stop();
                sleepModeActivate.Stop();
            }
        }
    }
}
