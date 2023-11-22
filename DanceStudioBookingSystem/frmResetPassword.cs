using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace DanceStudioBookingSystem
{
    public partial class frmResetPassword : Form
    {
        private Timer timer = new Timer();
        private int showPasswordDuration = 1000;
        public frmResetPassword()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Anna1" && txtNewPassword.Text == txtConfirmPassword.Text)
            {
                MessageBox.Show("The Password was reset. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmLogIn fLogIn = new frmLogIn();
                fLogIn.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformBackToLogIn(this);
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
            
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';// Hide the password
            timer.Stop();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '*';
        }

        private void picLock2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }
    }
}