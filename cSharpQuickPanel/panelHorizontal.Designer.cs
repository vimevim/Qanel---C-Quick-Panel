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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dots1
            // 
            this.dots1.AutoSize = true;
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
            this.buttonElipse1.Location = new System.Drawing.Point(45, 45);
            this.buttonElipse1.Name = "buttonElipse1";
            this.buttonElipse1.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse1.TabIndex = 3;
            this.buttonElipse1.Text = "btn1";
            this.buttonElipse1.UseVisualStyleBackColor = false;
            // 
            // panelHorizontal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(400, 150);
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
            this.MouseLeave += new System.EventHandler(this.panelHorizontal_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}