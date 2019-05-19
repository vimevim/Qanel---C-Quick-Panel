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
    public partial class panelVertical : Form
    {
        public panelVertical()
        {
            InitializeComponent();
        }

        private void panelVertical_Load(object sender, EventArgs e)
        {
            this.Width = 5;
            this.Height = 400;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
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
            }
        }

        private void panelVertical_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = (e.Y + this.Top - mouseDownLocation.Y);
            }
        }

        private void panelVertical_MouseLeave(object sender, EventArgs e)
        {

            if (this.Width == 150)
            {
                kepenkKapat.Start();
            }
        }

        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            this.Width += 5;
            this.Left -= 5;
            if (this.Width == 150)
            {
                kepenkAc.Stop();
            }
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            this.Width -= 5;
            this.Left += 5;
            if (this.Width == 5)
            {
                kepenkKapat.Stop();
            }
        }

    }
}
