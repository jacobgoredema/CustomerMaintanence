namespace CustomerMaintenance
{
    partial class frmAddMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewData = new System.Windows.Forms.ListBox();
            this.btnAddWholesale = new System.Windows.Forms.Button();
            this.btnAddRetail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers:";
            // 
            // lstViewData
            // 
            this.lstViewData.FormattingEnabled = true;
            this.lstViewData.Location = new System.Drawing.Point(12, 25);
            this.lstViewData.Name = "lstViewData";
            this.lstViewData.Size = new System.Drawing.Size(348, 147);
            this.lstViewData.TabIndex = 1;
            // 
            // btnAddWholesale
            // 
            this.btnAddWholesale.Location = new System.Drawing.Point(366, 26);
            this.btnAddWholesale.Name = "btnAddWholesale";
            this.btnAddWholesale.Size = new System.Drawing.Size(75, 23);
            this.btnAddWholesale.TabIndex = 2;
            this.btnAddWholesale.Text = "Add Wholesale";
            this.btnAddWholesale.UseVisualStyleBackColor = true;
            this.btnAddWholesale.Click += new System.EventHandler(this.btnAddWholesale_Click);
            // 
            // btnAddRetail
            // 
            this.btnAddRetail.Location = new System.Drawing.Point(366, 55);
            this.btnAddRetail.Name = "btnAddRetail";
            this.btnAddRetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddRetail.TabIndex = 3;
            this.btnAddRetail.Text = "Add Retail";
            this.btnAddRetail.UseVisualStyleBackColor = true;
            this.btnAddRetail.Click += new System.EventHandler(this.btnAddRetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddRetail);
            this.Controls.Add(this.btnAddWholesale);
            this.Controls.Add(this.lstViewData);
            this.Controls.Add(this.label1);
            this.Name = "frmAddMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstViewData;
        private System.Windows.Forms.Button btnAddWholesale;
        private System.Windows.Forms.Button btnAddRetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}