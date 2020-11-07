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
            Changes();
        }
        public void Changes()
        {
            kepenkKapat.Stop();
            this.Visible = ayarlar.Default.visibility;
            this.Opacity = ayarlar.Default.opacity;
            this.BackColor = ayarlar.Default.renk;
            if (ayarlar.Default.panelMod == "left")
            {
                this.Top = 10;
                this.Height = ayarlar.Default.size;
                this.Width = 5;
                this.Left = 0;
                buttonElipse1.Left = 50;
                buttonElipse2.Left = 50;
                buttonElipse3.Left = 50;
                buttonElipse4.Left = 50;
                buttonElipse5.Left = 50;
                buttonElipse1.Top = 25;
                buttonElipse2.Top = 100;
                buttonElipse3.Top = 175;
                buttonElipse4.Top = 250;
                buttonElipse5.Top = 325;
            }
            else if (ayarlar.Default.panelMod == "right")
            {
                this.Top = 10;
                this.Height = ayarlar.Default.size;
                this.Width = 5;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                buttonElipse1.Left = 50;
                buttonElipse2.Left = 50;
                buttonElipse3.Left = 50;
                buttonElipse4.Left = 50;
                buttonElipse5.Left = 50;
                buttonElipse1.Top = 25;
                buttonElipse2.Top = 100;
                buttonElipse3.Top = 175;
                buttonElipse4.Top = 250;
                buttonElipse5.Top = 325;
            }
            else if (ayarlar.Default.panelMod == "top")
            {
                this.Left = 10;
                this.Width = ayarlar.Default.size;
                this.Top = 0;
                this.Height = 5;
                buttonElipse1.Top = 50;
                buttonElipse2.Top = 50;
                buttonElipse3.Top = 50;
                buttonElipse4.Top = 50;
                buttonElipse5.Top = 50;
                buttonElipse1.Left = 25;
                buttonElipse2.Left = 100;
                buttonElipse3.Left = 175;
                buttonElipse4.Left = 250;
                buttonElipse5.Left = 325;
            }
        }
        Point mouseDownLocation;

        private void ortak_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }

            if (this.Width == 5 || this.Height == 5)
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
                if (ayarlar.Default.panelMod == "top")
                {
                    this.Left = (e.X + this.Left - mouseDownLocation.X);
                }
                else
                {
                    this.Top = (e.Y + this.Top - mouseDownLocation.Y);
                }
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
                if (this.Width == 150 || this.Height == 150)
                {
                    kepenkKapat.Start();
                }
            }
            else
            {
                if (Cursor.Position.X < this.Left || Cursor.Position.X > (this.Left + this.Width) || Cursor.Position.Y < this.Top || Cursor.Position.Y > (this.Top + this.Height))
                {
                    if (this.Width == 150 || this.Height == 150)
                    {
                        kepenkKapat.Start();
                    }
                }
            }
        }


        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            if (ayarlar.Default.panelMod == "top")
            {
                this.Height += 5;
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                if (this.Height == 150)
                {
                    kepenkAc.Stop();
                }
            }
            else
            {
                this.Width += 5;
                if (ayarlar.Default.panelMod == "right")
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
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            if (ayarlar.Default.panelMod == "top")
            {
                this.Height -= 5;
                if (this.Opacity > ayarlar.Default.opacity)
                {
                    this.Opacity -= 0.05;
                }
                if (this.Height == 5)
                {
                    kepenkKapat.Stop();
                    sleepModeActivate.Stop();
                }
            }
            else
            {
                this.Width -= 5;
                if (ayarlar.Default.panelMod == "right")
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
}
