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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DanceStudioBookingSystem
{
    public partial class frmLogIn : Form
    {
        private Timer timer = new Timer();
        private int showPasswordDuration = 1000;

        public frmLogIn()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Anna@gmail.com" & txtPassword.Text == "12345678"){
                traverseForm(this, new frmMemberProfile(this));
            }
            else if(txtEmail.Text == "Admin1" & txtPassword.Text == "123")
            {
                traverseForm(this, new frmDBConnect(this));
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
