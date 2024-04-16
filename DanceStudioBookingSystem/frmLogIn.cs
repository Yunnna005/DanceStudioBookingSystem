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
using static DanceStudioBookingSystem.UtilFunctions_DB;
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
            string email = txtEmail.Text.ToLower();
            string password = txtPassword.Text;
            
            memberID = FindMemberID(email.ToLower(), password);
            if (memberID != 0){
                if (email.StartsWith("admin"))
                {
                    traverseForm(this, new frmDBConnect(this));
                }
                else
                {
                    traverseForm(this, new frmMemberProfile(memberID));                 
                }
            }
            else
            {
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
    }
}
