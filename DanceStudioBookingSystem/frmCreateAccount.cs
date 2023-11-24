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
    public partial class frmCreateAccount : Form
    {     
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn fLogIn = new frmLogIn();
            fLogIn.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null ||  txtUsername.Text.Length < 8 || char.IsDigit(txtUsername.Text[0]))
            {
                MessageBox.Show("Please enter the username: \n\n1. More than 8 characters\n2. Does not start from number\n3. Does not start from symbol", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if (txtEmail.Text == null || txtEmail.Text.Length < 5 || !txtEmail.Text.Contains("@") && (txtEmail.Text.EndsWith(".com") || 
                txtEmail.Text.EndsWith(".ie") || txtEmail.Text.EndsWith(".org") || txtEmail.Text.EndsWith(".net")))
            {
                MessageBox.Show("Please enter valid email address", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.ResetText();
                txtEmail.Focus();

            }else if (txtPhone.Text == null || txtPhone.Text.Length < 9 || !txtPhone.Text.StartsWith("+"))
            {
                MessageBox.Show("Please enter valid phone number that starts from +", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.ResetText();
                txtPhone.Focus();
            }else if (txtPassword.Text == null || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("The password must contain at least 8 characters", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.ResetText();
                txtPassword.Focus();
            }
            else
            {
                string gender;
                if (radMale.Checked)
                {
                    gender = "Male";
                }else if (radFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }

                MessageBox.Show("Account was created. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmLogIn fLogIn = new frmLogIn();
                fLogIn.Show();
            }  
        }
    }
}
