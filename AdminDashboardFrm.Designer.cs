namespace LoginSystemWithRoles
{
    partial class AdminDashboardFrm
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
            this.lblAdminDescription = new System.Windows.Forms.Label();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminDescription
            // 
            this.lblAdminDescription.AutoSize = true;
            this.lblAdminDescription.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDescription.Location = new System.Drawing.Point(72, 30);
            this.lblAdminDescription.Name = "lblAdminDescription";
            this.lblAdminDescription.Size = new System.Drawing.Size(471, 38);
            this.lblAdminDescription.TabIndex = 0;
            this.lblAdminDescription.Text = "Welcome to the Admin Dashboard";
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(92, 144);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(141, 32);
            this.btnAdminLogout.TabIndex = 1;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // AdminDashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.lblAdminDescription);
            this.Name = "AdminDashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminDescription;
        private System.Windows.Forms.Button btnAdminLogout;
    }
}