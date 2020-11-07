namespace cSharpQuickPanel
{
    partial class Panel
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kepenkKapat = new System.Windows.Forms.Timer(this.components);
            this.kepenkAc = new System.Windows.Forms.Timer(this.components);
            this.sleepModeActivate = new System.Windows.Forms.Timer(this.components);
            this.buttonElipse5 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse4 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse3 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse2 = new cSharpQuickPanel.ButtonElipse();
            this.buttonElipse1 = new cSharpQuickPanel.ButtonElipse();
            this.SuspendLayout();
            // 
            // kepenkKapat
            // 
            this.kepenkKapat.Interval = 10;
            this.kepenkKapat.Tick += new System.EventHandler(this.kepenkKapat_Tick);
            // 
            // kepenkAc
            // 
            this.kepenkAc.Interval = 10;
            this.kepenkAc.Tick += new System.EventHandler(this.kepenkAc_Tick);
            // 
            // sleepModeActivate
            // 
            this.sleepModeActivate.Interval = 1000;
            this.sleepModeActivate.Tick += new System.EventHandler(this.sleepModeActivate_Tick);
            // 
            // buttonElipse5
            // 
            this.buttonElipse5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse5.Location = new System.Drawing.Point(50, 325);
            this.buttonElipse5.Name = "buttonElipse5";
            this.buttonElipse5.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse5.TabIndex = 8;
            this.buttonElipse5.UseVisualStyleBackColor = false;
            // 
            // buttonElipse4
            // 
            this.buttonElipse4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse4.Location = new System.Drawing.Point(50, 250);
            this.buttonElipse4.Name = "buttonElipse4";
            this.buttonElipse4.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse4.TabIndex = 8;
            this.buttonElipse4.UseVisualStyleBackColor = false;
            // 
            // buttonElipse3
            // 
            this.buttonElipse3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse3.Location = new System.Drawing.Point(50, 175);
            this.buttonElipse3.Name = "buttonElipse3";
            this.buttonElipse3.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse3.TabIndex = 8;
            this.buttonElipse3.UseVisualStyleBackColor = false;
            // 
            // buttonElipse2
            // 
            this.buttonElipse2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse2.Location = new System.Drawing.Point(50, 100);
            this.buttonElipse2.Name = "buttonElipse2";
            this.buttonElipse2.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse2.TabIndex = 8;
            this.buttonElipse2.UseVisualStyleBackColor = false;
            // 
            // buttonElipse1
            // 
            this.buttonElipse1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonElipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse1.Location = new System.Drawing.Point(50, 25);
            this.buttonElipse1.Name = "buttonElipse1";
            this.buttonElipse1.Size = new System.Drawing.Size(50, 50);
            this.buttonElipse1.TabIndex = 8;
            this.buttonElipse1.UseVisualStyleBackColor = false;
            // 
            // Panel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::cSharpQuickPanel.ayarlar.Default.renk;
            this.ClientSize = new System.Drawing.Size(150, 400);
            this.Controls.Add(this.buttonElipse5);
            this.Controls.Add(this.buttonElipse4);
            this.Controls.Add(this.buttonElipse3);
            this.Controls.Add(this.buttonElipse2);
            this.Controls.Add(this.buttonElipse1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Panel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ortak_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonElipse buttonElipse1;
        private System.Windows.Forms.Timer kepenkKapat;
        private System.Windows.Forms.Timer kepenkAc;
        private System.Windows.Forms.Timer sleepModeActivate;
        private ButtonElipse buttonElipse2;
        private ButtonElipse buttonElipse3;
        private ButtonElipse buttonElipse4;
        private ButtonElipse buttonElipse5;
    }
}