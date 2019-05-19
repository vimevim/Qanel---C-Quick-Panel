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
            this.Location = new Point(0, 0);
            this.Size = new Size(400, 5);
        }

        private void panelHorizontal_MouseClick(object sender, MouseEventArgs e)
        {
            this.Location = new Point(20, 0);
        }

        Point mouseDownLocation;

        private void ortak_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
            if(this.Height == 5)
            {
                kepenkKapat.Start();
            }
        }
        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left = (e.X + this.Left - mouseDownLocation.X);
            }
        }

        private void panelHorizontal_MouseUp(object sender, MouseEventArgs e)
        {
            kepenkKapat.Start();
        }

        private void panelHorizontal_MouseLeave(object sender, EventArgs e)
        {

            if (this.Height == 150)
            {
                kepenkAc.Start();
            }
        }

        private void kepenkAc_Tick(object sender, EventArgs e)
        {
            this.Height += 5;
            if(this.Height==150)
            {
                kepenkKapat.Stop();
            }
        }

        private void kepenkKapat_Tick(object sender, EventArgs e)
        {
            this.Height -= 5;
            if (this.Height == 5)
            {
                kepenkAc.Stop();
            }
        }
    }
}
