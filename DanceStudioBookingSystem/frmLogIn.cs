using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    public partial class frmLogIn : Form
    {
        private Timer timer = new Timer();
        private int showPasswordDuration = 1000;
        public frmLogIn()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Anna" & txtPassword.Text == "123"){
                this.Hide();
                frmMemberProfile fMemberProfile = new frmMemberProfile();
                fMemberProfile.Show();

            }
            else if(txtUsername.Text == "Admin1" & txtPassword.Text == "123")
            {
                this.Close();
                frmMainMenuAdmin fMainMenuAdmin = new frmMainMenuAdmin();
                fMainMenuAdmin.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }


        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Close();
            frmResetPassword fResetPassword = new frmResetPassword();
            fResetPassword.Show();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCreateAccount fCreateAccount = new frmCreateAccount();
            fCreateAccount.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            timer.Stop();
        }

    }
}
