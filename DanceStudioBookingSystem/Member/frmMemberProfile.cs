using DanceStudioBookingSystem.Member;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DanceStudioBookingSystem
{
    public partial class frmMemberProfile : Form
    {
        Form parent;
        private int memberID;
        public frmMemberProfile(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();

        }

        public frmMemberProfile(int memberID)
        {
            InitializeComponent();
            this.memberID = memberID;

            LoadUserDetails(memberID);
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmBookClass(this));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            PerformLogOut(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmUpdateMember(memberID));
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel class?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The class was canceled.", "Cancelled Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void frmMemberProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void LoadUserDetails(int memberID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string SQLquery = "SELECT Firstname, Lastname, DOB, Gender, Phone, Email FROM Members WHERE Member_ID = :memberID";

                using (OracleCommand command = new OracleCommand(SQLquery, conn))
                {
                    // Set the value for the bind variable
                    command.Parameters.Add(new OracleParameter("memberID", memberID));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display user details in respective controls
                            lblWriteUsername.Text = reader["Firstname"].ToString()+ " " + reader["Lastname"].ToString();
                            lblWriteDOB.Text = reader["DOB"].ToString();
                            lblWriteGender.Text = reader["Gender"].ToString();
                            lblWritePhone.Text = reader["Phone"].ToString();
                            lblWriteEmail.Text = reader["Email"].ToString(); ;
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
