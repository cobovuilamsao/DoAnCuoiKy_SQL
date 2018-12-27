namespace Coffee_Store_Management_Software
{
    partial class Profit
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
            this.Checkinlable = new System.Windows.Forms.Label();
            this.Checkoutlable = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Checkinlable
            // 
            this.Checkinlable.AutoSize = true;
            this.Checkinlable.Location = new System.Drawing.Point(472, 10);
            this.Checkinlable.Name = "Checkinlable";
            this.Checkinlable.Size = new System.Drawing.Size(52, 13);
            this.Checkinlable.TabIndex = 1;
            this.Checkinlable.Text = "Check_in";
            // 
            // Checkoutlable
            // 
            this.Checkoutlable.AutoSize = true;
            this.Checkoutlable.Location = new System.Drawing.Point(582, 10);
            this.Checkoutlable.Name = "Checkoutlable";
            this.Checkoutlable.Size = new System.Drawing.Size(59, 13);
            this.Checkoutlable.TabIndex = 1;
            this.Checkoutlable.Text = "Check_out";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1287, 537);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1287, 537);
            this.Controls.Add(this.Checkoutlable);
            this.Controls.Add(this.Checkinlable);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Profit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Checkinlable;
        private System.Windows.Forms.Label Checkoutlable;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}