namespace cSharpQuickPanel
{
    partial class panelHorizontal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dots1 = new System.Windows.Forms.Label();
            this.dots2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lineUp = new System.Windows.Forms.Label();
            this.lineMiddle = new System.Windows.Forms.Label();
            this.lineDown = new System.Windows.Forms.Label();
            this.kepenkKapat = new System.Windows.Forms.Timer(this.components);
            this.kepenkAc = new System.Windows.Forms.Timer(this.components);
            this.buttonElipse1 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse2 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse3 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse4 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse5 = new cSharpQuickPanel.ButtonElipse();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sleepModeActivate = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dots1
            // 
            this.dots1.AutoSize = true;
            this.dots1.Enabled = false;
            this.dots1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dots1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dots1.Location = new System.Drawing.Point(20, 10);
            this.dots1.Name = "dots1";
            this.dots1.Size = new System.Drawing.Size(62, 29);
            this.dots1.TabIndex = 0;
            this.dots1.Text = ":::::::";
            // 
            // dots2
            // 
            this.dots2.AutoSize = true;
            this.dots2.Enabled = false;
            this.dots2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dots2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dots2.Location = new System.Drawing.Point(318, 10);
            this.dots2.Name = "dots2";
            this.dots2.Size = new System.Drawing.Size(62, 29);
            this.dots2.TabIndex = 0;
            this.dots2.Text = ":::::::";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 3);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lineUp);
            this.panel2.Controls.Add(this.lineMiddle);
            this.panel2.Controls.Add(this.lineDown);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 30);
            this.panel2.TabIndex = 2;
            // 
            // lineUp
            // 
            this.lineUp.AutoSize = true;
            this.lineUp.BackColor = System.Drawing.Color.Transparent;
            this.lineUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lineUp.Location = new System.Drawing.Point(167, -29);
            this.lineUp.Name = "lineUp";
            this.lineUp.Size = new System.Drawing.Size(66, 48);
            this.lineUp.TabIndex = 3;
            this.lineUp.Text = "__";
            // 
            // lineMiddle
            // 
            this.lineMiddle.AutoSize = true;
            this.lineMiddle.BackColor = System.Drawing.Color.Transparent;
            this.lineMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineMiddle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lineMiddle.Location = new System.Drawing.Point(167, -24);
            this.lineMiddle.Name = "lineMiddle";
            this.lineMiddle.Size = new System.Drawing.Size(66, 48);
            this.lineMiddle.TabIndex = 3;
            this.lineMiddle.Text = "__";
            // 
            // lineDown
            // 
            this.lineDown.AutoSize = true;
            this.lineDown.BackColor = System.Drawing.Color.Transparent;
            this.lineDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lineDown.Location = new System.Drawing.Point(167, -19);
            this.lineDown.Name = "lineDown";
            this.lineDown.Size = new System.Drawing.Size(66, 48);
            this.lineDown.TabIndex = 3;
            this.lineDown.Text = "__";
            // 
            // kepenkKapat
            // 
            this.kepenkKapat.Interval = 10;
            this.kepenkKapat.Tick += new System.EventHandler(this.kepenkAc_Tick);
            // 
            // kepenkAc
            // 
            this.kepenkAc.Interval = 10;
            this.kepenkAc.Tick += new System.EventHandler(this.kepenkKapat_Tick);
            // 
            // buttonElipse1
            // 
            this.buttonElipse1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse1.Location = new System.Drawing.Point(25, 50);
            this.buttonElipse1.Name = "buttonElipse1";
            this.buttonElipse1.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse1.TabIndex = 3;
            this.buttonElipse1.Text = "btn1";
            this.buttonElipse1.UseVisualStyleBackColor = false;
            // 
            // buttonElipse2
            // 
            this.buttonElipse2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse2.Location = new System.Drawing.Point(100, 50);
            this.buttonElipse2.Name = "buttonElipse2";
            this.buttonElipse2.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse2.TabIndex = 3;
            this.buttonElipse2.Text = "btn1";
            this.buttonElipse2.UseVisualStyleBackColor = false;
            // 
            // buttonElipse3
            // 
            this.buttonElipse3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse3.Location = new System.Drawing.Point(175, 50);
            this.buttonElipse3.Name = "buttonElipse3";
            this.buttonElipse3.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse3.TabIndex = 3;
            this.buttonElipse3.Text = "btn1";
            this.buttonElipse3.UseVisualStyleBackColor = false;
            // 
            // buttonElipse4
            // 
            this.buttonElipse4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse4.Location = new System.Drawing.Point(250, 50);
            this.buttonElipse4.Name = "buttonElipse4";
            this.buttonElipse4.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse4.TabIndex = 3;
            this.buttonElipse4.Text = "btn1";
            this.buttonElipse4.UseVisualStyleBackColor = false;
            // 
            // buttonElipse5
            // 
            this.buttonElipse5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse5.Location = new System.Drawing.Point(325, 50);
            this.buttonElipse5.Name = "buttonElipse5";
            this.buttonElipse5.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse5.TabIndex = 3;
            this.buttonElipse5.Text = "btn1";
            this.buttonElipse5.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem,
            this.option3ToolStripMenuItem,
            this.option4ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 100);
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.option1ToolStripMenuItem.Text = "exit";
            this.option1ToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.option2ToolStripMenuItem.Text = "option2";
            // 
            // option3ToolStripMenuItem
            // 
            this.option3ToolStripMenuItem.Name = "option3ToolStripMenuItem";
            this.option3ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.option3ToolStripMenuItem.Text = "option3";
            // 
            // option4ToolStripMenuItem
            // 
            this.option4ToolStripMenuItem.Name = "option4ToolStripMenuItem";
            this.option4ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.option4ToolStripMenuItem.Text = "option4";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // sleepModeActivate
            // 
            this.sleepModeActivate.Interval = 1000;
            this.sleepModeActivate.Tick += new System.EventHandler(this.sleepModeActivate_Tick);
            // 
            // panelHorizontal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonElipse5);
            this.Controls.Add(this.buttonElipse4);
            this.Controls.Add(this.buttonElipse3);
            this.Controls.Add(this.buttonElipse2);
            this.Controls.Add(this.buttonElipse1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dots2);
            this.Controls.Add(this.dots1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelHorizontal";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.panelHorizontal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ortak_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dots1;
        private System.Windows.Forms.Label dots2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lineMiddle;
        private System.Windows.Forms.Label lineDown;
        private System.Windows.Forms.Label lineUp;
        private ButtonElipse buttonElipse1;
        private System.Windows.Forms.Timer kepenkKapat;
        private System.Windows.Forms.Timer kepenkAc;
        private ButtonElipse buttonElipse2;
        private ButtonElipse buttonElipse3;
        private ButtonElipse buttonElipse4;
        private ButtonElipse buttonElipse5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option4ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer sleepModeActivate;
    }
}