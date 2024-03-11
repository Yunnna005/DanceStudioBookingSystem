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
            string validationMemberDetails = ValidationMemberDetails(txtFirstname, txtSecondname, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB);
            if (validationMemberDetails == "Male" || validationMemberDetails == "Female" || validationMemberDetails == "Other")
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

                    Members aMember = new Members(txtFirstname.Text, txtSecondname.Text, validationMemberDetails, txtEmail.Text,txtPhone.Text, dtpDOB.Value, txtPassword.Text);
                    aMember.addMember();
                    traverseForm(this, new frmLogIn());
                }
            }
            else
            {
                MessageBox.Show(ValidationMemberDetails(txtFirstname, txtSecondname, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
