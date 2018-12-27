namespace Coffee_Store_Management_Software
{
    partial class Tablemanager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbcombiningtable = new System.Windows.Forms.ComboBox();
            this.btnCollectingtable = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numdiscount = new System.Windows.Forms.NumericUpDown();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmblistable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcategoryfood = new System.Windows.Forms.ComboBox();
            this.flowlayouttable = new System.Windows.Forms.FlowLayoutPanel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lab_NoTable = new System.Windows.Forms.Label();
            this.numfoodcount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnaddfood1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiscount)).BeginInit();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numfoodcount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMenuItem,
            this.accountMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminMenuItem.Text = "Admin";
            this.adminMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountMenuItem
            // 
            this.accountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountMenuItem.Name = "accountMenuItem";
            this.accountMenuItem.Size = new System.Drawing.Size(139, 20);
            this.accountMenuItem.Text = "Informational Account";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.cafe_lam_giam_ung_thu_da;
            this.panel7.Controls.Add(this.cmbcombiningtable);
            this.panel7.Controls.Add(this.btnCollectingtable);
            this.panel7.Location = new System.Drawing.Point(126, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(98, 76);
            this.panel7.TabIndex = 6;
            // 
            // cmbcombiningtable
            // 
            this.cmbcombiningtable.FormattingEnabled = true;
            this.cmbcombiningtable.Location = new System.Drawing.Point(14, 44);
            this.cmbcombiningtable.Name = "cmbcombiningtable";
            this.cmbcombiningtable.Size = new System.Drawing.Size(77, 26);
            this.cmbcombiningtable.TabIndex = 7;
            // 
            // btnCollectingtable
            // 
            this.btnCollectingtable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCollectingtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectingtable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCollectingtable.Location = new System.Drawing.Point(12, 3);
            this.btnCollectingtable.Name = "btnCollectingtable";
            this.btnCollectingtable.Size = new System.Drawing.Size(79, 38);
            this.btnCollectingtable.TabIndex = 0;
            this.btnCollectingtable.Text = "Combine";
            this.btnCollectingtable.UseVisualStyleBackColor = false;
            this.btnCollectingtable.Click += new System.EventHandler(this.btnCollectingtable_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.Crimson;
            this.btncheckout.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources._43952295_172383397001162_1022004046656962560_n;
            this.btncheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.Red;
            this.btncheckout.Location = new System.Drawing.Point(344, 42);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(161, 76);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "Check out ";
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel8.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.cafe_lam_giam_ung_thu_da;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.numdiscount);
            this.panel8.Location = new System.Drawing.Point(240, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(98, 76);
            this.panel8.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount";
            // 
            // numdiscount
            // 
            this.numdiscount.Location = new System.Drawing.Point(10, 42);
            this.numdiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numdiscount.Name = "numdiscount";
            this.numdiscount.Size = new System.Drawing.Size(69, 24);
            this.numdiscount.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel9.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.cafe_lam_giam_ung_thu_da;
            this.panel9.Controls.Add(this.cmblistable);
            this.panel9.Controls.Add(this.button1);
            this.panel9.Location = new System.Drawing.Point(14, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(98, 76);
            this.panel9.TabIndex = 5;
            // 
            // cmblistable
            // 
            this.cmblistable.FormattingEnabled = true;
            this.cmblistable.Location = new System.Drawing.Point(8, 44);
            this.cmblistable.Name = "cmblistable";
            this.cmblistable.Size = new System.Drawing.Size(83, 26);
            this.cmblistable.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Movement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Food name";
            // 
            // cmbfood
            // 
            this.cmbfood.FormattingEnabled = true;
            this.cmbfood.Location = new System.Drawing.Point(210, 43);
            this.cmbfood.Name = "cmbfood";
            this.cmbfood.Size = new System.Drawing.Size(196, 26);
            this.cmbfood.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Food category";
            // 
            // cmbcategoryfood
            // 
            this.cmbcategoryfood.FormattingEnabled = true;
            this.cmbcategoryfood.Location = new System.Drawing.Point(6, 43);
            this.cmbcategoryfood.Name = "cmbcategoryfood";
            this.cmbcategoryfood.Size = new System.Drawing.Size(198, 26);
            this.cmbcategoryfood.TabIndex = 5;
            this.cmbcategoryfood.SelectedIndexChanged += new System.EventHandler(this.cmbcategoryfood_SelectedIndexChanged);
            // 
            // flowlayouttable
            // 
            this.flowlayouttable.AutoScroll = true;
            this.flowlayouttable.BackColor = System.Drawing.Color.Yellow;
            this.flowlayouttable.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.starbucks_1024xx502_282_0_0;
            this.flowlayouttable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowlayouttable.Location = new System.Drawing.Point(348, 102);
            this.flowlayouttable.Name = "flowlayouttable";
            this.flowlayouttable.Size = new System.Drawing.Size(1014, 365);
            this.flowlayouttable.TabIndex = 3;
            this.flowlayouttable.Paint += new System.Windows.Forms.PaintEventHandler(this.flowlayouttable_Paint);
            // 
            // lsvbill
            // 
            this.lsvbill.BackgroundImageTiled = true;
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price,
            this.count,
            this.sum});
            this.lsvbill.GridLines = true;
            this.lsvbill.Location = new System.Drawing.Point(2, 26);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(340, 723);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // price
            // 
            this.price.Text = "price";
            // 
            // count
            // 
            this.count.Text = "count";
            // 
            // sum
            // 
            this.sum.Text = "sum";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Location = new System.Drawing.Point(558, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 34);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sum";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.ForeColor = System.Drawing.Color.Red;
            this.txtSum.Location = new System.Drawing.Point(54, 6);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSum.Size = new System.Drawing.Size(207, 26);
            this.txtSum.TabIndex = 1;
            this.txtSum.Text = "0";
            // 
            // lab_NoTable
            // 
            this.lab_NoTable.AutoSize = true;
            this.lab_NoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_NoTable.ForeColor = System.Drawing.Color.Red;
            this.lab_NoTable.Location = new System.Drawing.Point(560, 11);
            this.lab_NoTable.Name = "lab_NoTable";
            this.lab_NoTable.Size = new System.Drawing.Size(36, 20);
            this.lab_NoTable.TabIndex = 3;
            this.lab_NoTable.Text = "No.";
            // 
            // numfoodcount
            // 
            this.numfoodcount.Location = new System.Drawing.Point(417, 44);
            this.numfoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numfoodcount.Name = "numfoodcount";
            this.numfoodcount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numfoodcount.Size = new System.Drawing.Size(132, 24);
            this.numfoodcount.TabIndex = 6;
            this.numfoodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(419, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Restriction";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.Slide1_1_2;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnaddfood1);
            this.groupBox2.Controls.Add(this.lab_NoTable);
            this.groupBox2.Controls.Add(this.numfoodcount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbcategoryfood);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbfood);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(351, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1011, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding food";
            // 
            // btnaddfood1
            // 
            this.btnaddfood1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnaddfood1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddfood1.Location = new System.Drawing.Point(843, 41);
            this.btnaddfood1.Name = "btnaddfood1";
            this.btnaddfood1.Size = new System.Drawing.Size(162, 25);
            this.btnaddfood1.TabIndex = 1;
            this.btnaddfood1.Text = "Add  food";
            this.btnaddfood1.UseVisualStyleBackColor = false;
            this.btnaddfood1.Click += new System.EventHandler(this.btnaddfood_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.cafe_lam_giam_ung_thu_da;
            this.groupBox3.Controls.Add(this.btncheckout);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(348, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1014, 137);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // Tablemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Coffee_Store_Management_Software.Properties.Resources.cafe_lam_giam_ung_thu_da;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lsvbill);
            this.Controls.Add(this.flowlayouttable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tablemanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablemanager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tablemanager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiscount)).EndInit();
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numfoodcount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowlayouttable;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numdiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcategoryfood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmblistable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmbcombiningtable;
        private System.Windows.Forms.Button btnCollectingtable;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lab_NoTable;
        private System.Windows.Forms.NumericUpDown numfoodcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnaddfood1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}