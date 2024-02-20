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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DanceStudioBookingSystem
{
    public partial class frmLogIn : Form
    {
        private Timer timer = new Timer();
        private int showPasswordDuration = 1000;
        int memberID;

        public frmLogIn()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            
            memberID = ValidateLogin(email, password);
            if (memberID != 0){
                if (email.StartsWith("admin"))
                {
                    this.Hide();
                    frmDBConnect nextForm = new frmDBConnect(this);
                    nextForm.Show();
                }
                else
                {
                    this.Hide();
                    frmMemberProfile nextForm = new frmMemberProfile(memberID);
                    nextForm.Show();
                    
                }
            }
            else
            {
                MessageBox.Show(memberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }  
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmResetPassword(this));
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmCreateAccount(this));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            timer.Stop();
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private int ValidateLogin(string email, string password)
        {
            int MemberID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Members WHERE Email = :Email AND Password = :Password";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                    command.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MemberID = (int)reader["Member_ID"];

                        }
                    }
                    return 0;
                }
            }
        }
    }
}
