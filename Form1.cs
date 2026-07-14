using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginSystemWithRoles
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            chkShowPassword.Checked = false;

            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Please enter your username.",
                                "Missing Username",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter your password.",
                                "Missing Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role.",
                                "Missing Role",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                cmbRole.Focus();
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            if (username == "admin" && password == "admin123" && role == "Admin")
            {
                MessageBox.Show("Admin login successful.",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                AdminDashboardFrm adminForm = new AdminDashboardFrm();
                adminForm.Show();

                this.Hide();
            }
            else if (username == "staff" && password == "staff123" && role == "Staff")
            {
                MessageBox.Show("Staff login successful.",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                StaffDashboardForm staffForm = new StaffDashboardForm();
                staffForm.Show();

                this.Hide();
            }
            else
            {
                loginAttempts++;

                MessageBox.Show($"Invalid username, password, or role.\nAttempt {loginAttempts} of 3.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();

                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Too many failed login attempts. The Login button will be disabled.",
                                    "Login Locked",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    btnLogin.Enabled = false;

                }
            }
        }


            

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");

            cmbRole.SelectedIndex = -1;
            txtUsername.Focus();

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                          "Confirm Exit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
