using DanceStudioBookingSystem.Member;
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
    public partial class frmUpdateMember : Form
    {
        Form parent;
        public frmUpdateMember(Form parentForm)
        {





            parent = parentForm;
            InitializeComponent();
            txtFirstName.Text = "Anna";
            txtSecondName.Text = "Kovalenko";
            dtpDOB.Value = new DateTime(2005, 08, 24);
            txtEmail.Text = "Anna@gmail.com";
            txtPhone.Text = "3530852433543";
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go to your profile? \n\nYour changes will not be saved.", "Edit Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes){
                traverseForm(this, new frmMemberProfile(this));
            }
            else
            {
                return;
            }
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot book class in edit profile mode.", "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You loged out. Go to Log in.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                traverseForm(this, new frmLogIn());
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string validationMemberDetails = ValidationMemberDetails(txtFirstName, txtSecondName, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB);
            DialogResult result = MessageBox.Show("Do you want to delete you profile?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Create an instance of Member and instantiate with values from form controls
                Members aMember = new Members(txtFirstName.Text, txtSecondName.Text, validationMemberDetails, txtEmail.Text,
                    txtPhone.Text, dtpDOB.Text, txtNewPassword.Text);

                //invoke the method to add the data to the Members table
                aMember.updateMember();

                traverseForm(this, new frmLogIn());
                MessageBox.Show("Your profile was deleted.", "Delete Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your chandes was not saved.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            traverseForm(this, new frmMemberProfile(this));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationMemberDetails = ValidationMemberDetails(txtFirstName, txtSecondName, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB);
            if (validationMemberDetails == "Male" || validationMemberDetails == "Female" || validationMemberDetails == "Other")
            {   if (!string.IsNullOrEmpty(txtOldPassword.Text) || !string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    if (txtOldPassword.Text.Length < 8)
                    {
                        MessageBox.Show("The password must contain at least 8 characters", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPassword.Focus();
                    }
                    else if (txtOldPassword.Text != txtNewPassword.Text)
                    {
                        MessageBox.Show("The passwords do not the same.", "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPassword.Focus();
                    }
                    else
                    {
                        //Create an instance of Member and instantiate with values from form controls
                        Members aMember = new Members(txtFirstName.Text, txtSecondName.Text, validationMemberDetails, txtEmail.Text,
                        txtPhone.Text, dtpDOB.Text,txtNewPassword.Text);

                        //invoke the method to add the data to the Members table
                        aMember.UpdateMemberAndPassword();

                        MessageBox.Show("Your chandes was saved.\n\nThe Password was changed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        traverseForm(this, new frmMemberProfile(this));
                    }
                }
                else
                {
                    MessageBox.Show("Your chandes was saved.\n\nThe Password was not changed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Create an instance of Member and instantiate with values from form controls
                    Members aMember = new Members(txtFirstName.Text, txtSecondName.Text, validationMemberDetails, txtEmail.Text,
                        txtPhone.Text, dtpDOB.Text);

                    //invoke the method to add the data to the Members table
                    aMember.updateMember();


                    traverseForm(this, new frmMemberProfile(this));
                }    
            }
            else
            {
                MessageBox.Show(ValidationMemberDetails(txtFirstName, txtSecondName, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditMemberProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
