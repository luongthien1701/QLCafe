namespace Quanlycafe
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbVAT = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp3.SuspendLayout();
            this.tp4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp1);
            this.tabControl.Controls.Add(this.tp2);
            this.tabControl.Controls.Add(this.tp3);
            this.tabControl.Controls.Add(this.tp4);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(643, 507);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabPageControl1_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.AutoScroll = true;
            this.tp1.Controls.Add(this.flowLayoutPanel1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(635, 478);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "ĐỒ NÓNG";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 444);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tp2
            // 
            this.tp2.AutoScroll = true;
            this.tp2.Controls.Add(this.flowLayoutPanel2);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(635, 478);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "ĐỒ LẠNH";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(35, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(558, 473);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tp3
            // 
            this.tp3.AutoScroll = true;
            this.tp3.Controls.Add(this.flowLayoutPanel3);
            this.tp3.Location = new System.Drawing.Point(4, 25);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(635, 478);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "CAFE";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(41, 30);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(558, 473);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // tp4
            // 
            this.tp4.AutoScroll = true;
            this.tp4.Controls.Add(this.flowLayoutPanel4);
            this.tp4.Location = new System.Drawing.Point(4, 25);
            this.tp4.Name = "tp4";
            this.tp4.Padding = new System.Windows.Forms.Padding(3);
            this.tp4.Size = new System.Drawing.Size(635, 478);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "ĐỒ ĂN VẶT";
            this.tp4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(41, 30);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(558, 473);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbVAT);
            this.panel1.Controls.Add(this.lbCost);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(661, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 564);
            this.panel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(359, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(359, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "VND";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(295, 514);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(19, 20);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "0";
            // 
            // lbVAT
            // 
            this.lbVAT.AutoSize = true;
            this.lbVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVAT.Location = new System.Drawing.Point(295, 482);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(19, 20);
            this.lbVAT.TabIndex = 14;
            this.lbVAT.Text = "0";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(295, 452);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(19, 20);
            this.lbCost.TabIndex = 13;
            this.lbCost.Text = "0";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Thuế VAT(10%):";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Chi phí:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(73, 139);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(43, 22);
            this.txt1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bàn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chúc quý khách ngon miệng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền:";
            // 
            // dgv
            // 
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.Location = new System.Drawing.Point(3, 195);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 5;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(395, 254);
            this.dgv.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 155;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ĐG";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PHIẾU THANH TOÁN";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(161, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "K82/63 Nguyễn Lương Bằng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tralalelo Tralala Coffee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.newToolStripMenuItem.Text = "New Bill";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "ĐĂNG XUẤT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit);
            // 
            // Staff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.tabControl.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.tp4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabPage tp4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}