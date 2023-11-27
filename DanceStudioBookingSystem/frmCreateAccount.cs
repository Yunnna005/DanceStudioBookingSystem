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
            string validationMemberDetails = UtilFunctions.ValidatonMemberDetails(txtUsername.Text, txtEmail.Text, txtPhone.Text, radMale.Checked, radFemale.Checked, radOther.Checked);
            if (validationMemberDetails == "Male" || validationMemberDetails == "Female" || validationMemberDetails == "Other")
            {
                if (txtPassword.Text == null || txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("The password must contain at least 8 characters", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.ResetText();
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Account was created. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    frmLogIn fLogIn = new frmLogIn();
                                    fLogIn.Show();
                }
            }
            else
            {
                MessageBox.Show(UtilFunctions.ValidatonMemberDetails(txtUsername.Text, txtEmail.Text, txtPhone.Text, radMale.Checked, radFemale.Checked, radOther.Checked), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
