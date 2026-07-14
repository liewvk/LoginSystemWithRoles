namespace LoginSystemWithRoles
{
    partial class StaffDashboardForm
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
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lblStaffDescription = new System.Windows.Forms.Label();
            this.btnStaffLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTitle.Location = new System.Drawing.Point(72, 45);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(446, 38);
            this.lblStaffTitle.TabIndex = 0;
            this.lblStaffTitle.Text = "Welcome to the Staff Dashboard";
            // 
            // lblStaffDescription
            // 
            this.lblStaffDescription.AutoSize = true;
            this.lblStaffDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDescription.Location = new System.Drawing.Point(39, 107);
            this.lblStaffDescription.Name = "lblStaffDescription";
            this.lblStaffDescription.Size = new System.Drawing.Size(494, 20);
            this.lblStaffDescription.TabIndex = 1;
            this.lblStaffDescription.Text = "Staff users can view records and perform daily operational tasks ";
            // 
            // btnStaffLogout
            // 
            this.btnStaffLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogout.Location = new System.Drawing.Point(151, 167);
            this.btnStaffLogout.Name = "btnStaffLogout";
            this.btnStaffLogout.Size = new System.Drawing.Size(149, 36);
            this.btnStaffLogout.TabIndex = 2;
            this.btnStaffLogout.Text = "Logout";
            this.btnStaffLogout.UseVisualStyleBackColor = true;
            this.btnStaffLogout.Click += new System.EventHandler(this.btnStaffLogout_Click);
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnStaffLogout);
            this.Controls.Add(this.lblStaffDescription);
            this.Controls.Add(this.lblStaffTitle);
            this.Name = "StaffDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.Label lblStaffDescription;
        private System.Windows.Forms.Button btnStaffLogout;
    }
}