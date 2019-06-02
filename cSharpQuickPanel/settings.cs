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
    public partial class settings : Form
    {
        Panel panel = new Panel();
        public settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {
            panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ayarlar.Default.size = 100;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ayarlar.Default.size = 300;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayarlar.Default.size = 400;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ayarlar.Default.opacity = 0.50;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ayarlar.Default.opacity = 0.75;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ayarlar.Default.opacity = 1;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ayarlar.Default.visibility = true;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ayarlar.Default.visibility = false;
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ayarlar.Default.renk = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            ayarlar.Default.Save();
            panel.Changes();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ayarlar.Default.renk = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ayarlar.Default.panelMod = "left";
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ayarlar.Default.panelMod = "right";
            ayarlar.Default.Save();
            panel.Changes();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ayarlar.Default.panelMod = "top";
            ayarlar.Default.Save();
            panel.Changes();
        }
    }
}
