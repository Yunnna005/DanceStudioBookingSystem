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
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Anna" & txtPassword.Text == "123"){
                this.Hide();
                frmMemberProfile fMemberProfile = new frmMemberProfile();
                fMemberProfile.Show();
            }else if(txtUsername.Text == "Admin1" & txtPassword.Text == "123")
            {
                this.Hide();
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
            this.Hide();
            frmResetPassword fResetPassword = new frmResetPassword();
            fResetPassword.Show();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAccount fCreateAccount = new frmCreateAccount();
            fCreateAccount.Show();
        }
    }
}
