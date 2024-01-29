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
        private string email;
        public frmMemberProfile(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();

        }

        public frmMemberProfile(string email)
        {
            InitializeComponent();
            this.email = email;

            LoadUserDetails();
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
            traverseForm(this, new frmUpdateMember(email));
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
                            lblWriteUsername.Text = reader["Firstname"].ToString() + reader["Lastname"].ToString();
                            lblWriteDOB.Text = reader["DOB"].ToString();
                            lblWriteGender.Text = reader["Gender"].ToString();
                            lblWritePhone.Text = reader["Phone"].ToString();
                            lblWriteEmail.Text = email;
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
