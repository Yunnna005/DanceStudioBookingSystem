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
                this.Close();
                frmMemberProfile fMemberProfile = new frmMemberProfile();
                fMemberProfile.Show();


                //Members Details
                string username = txtUsername.Text;
                string DOB = "24/08/2005";
                string Gender = "Female";
                string Phone = "+353852022777";
                string Email = "anna.kovalenko@students.ittralee.ie";
                fMemberProfile.SetLabelText(username, DOB, Gender, Phone, Email);

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
    }
}
