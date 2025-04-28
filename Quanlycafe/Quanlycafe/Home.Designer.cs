namespace Quanlycafe
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtus);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 563);
            this.panel1.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.DarkGreen;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtpass.Location = new System.Drawing.Point(544, 335);
            this.txtpass.Margin = new System.Windows.Forms.Padding(0);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(194, 35);
            this.txtpass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtus
            // 
            this.txtus.BackColor = System.Drawing.Color.DarkGreen;
            this.txtus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtus.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtus.Location = new System.Drawing.Point(544, 270);
            this.txtus.Margin = new System.Windows.Forms.Padding(0);
            this.txtus.Multiline = true;
            this.txtus.Name = "txtus";
            this.txtus.Size = new System.Drawing.Size(194, 35);
            this.txtus.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(896, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tralalelo Tralala Coffee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpass;
    }
}

