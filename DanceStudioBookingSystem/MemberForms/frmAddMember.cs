using DanceStudioBookingSystem.Member;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;

namespace DanceStudioBookingSystem
{
    public partial class frmCreateAccount : Form
    {
        Form parent;
        public frmCreateAccount(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmLogIn());
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string validationMemberDetails = ValidationMemberDetails(0,txtFirstname, txtSecondname, txtEmail, txtPhone, dtpDOB);
            if (validationMemberDetails == "valid")
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("The password must contain at least 8 characters", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Account was created. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Members aMember = new Members(txtFirstname.Text, txtSecondname.Text, GetGender(radMale, radFemale, radOther), txtEmail.Text,txtPhone.Text, dtpDOB.Value, txtPassword.Text);
                    aMember.addMember();
                    traverseForm(this, new frmLogIn());
                }
            }
            else
            {
                MessageBox.Show(ValidationMemberDetails(0,txtFirstname, txtSecondname, txtEmail, txtPhone, dtpDOB), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
