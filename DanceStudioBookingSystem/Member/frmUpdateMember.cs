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
    public partial class frmUpdateMember : Form
    {
        Form parent;
        private string email;
        public frmUpdateMember(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }
        public frmUpdateMember(string email)
        {
            InitializeComponent();

            this.email = email;

            LoadUserDetails();
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
            DialogResult result = MessageBox.Show("Do you want to delete you profile?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

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
            string validationMemberDetails = ValidationMemberDetails(txtFirstName, txtLastName, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB);
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
                        Members aMember = new Members(txtFirstName.Text, txtLastName.Text, validationMemberDetails, txtEmail.Text,
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
                    Members aMember = new Members(txtFirstName.Text, txtLastName.Text, validationMemberDetails, txtEmail.Text,
                        txtPhone.Text, dtpDOB.Text);

                    //invoke the method to add the data to the Members table
                    aMember.updateMember(email);


                    traverseForm(this, new frmMemberProfile(email));
                }    
            }
            else
            {
                MessageBox.Show(ValidationMemberDetails(txtFirstName, txtLastName, txtEmail, txtPhone, radMale, radFemale, radOther, dtpDOB), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditMemberProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void LoadUserDetails()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Members WHERE Email = :Email";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display user details in respective controls
                            txtFirstName.Text = reader["Firstname"].ToString();
                            txtLastName.Text = reader["Lastname"].ToString();
                            dtpDOB.Text = reader["DOB"].ToString();
                            //lblWriteGender.Text = reader["Gender"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtEmail.Text = email;
                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
