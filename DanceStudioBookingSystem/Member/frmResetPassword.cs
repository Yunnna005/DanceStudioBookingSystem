﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using static DanceStudioBookingSystem.UtilFunctions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using DanceStudioBookingSystem.Member;

namespace DanceStudioBookingSystem
{
    public partial class frmResetPassword : Form
    {
        Form parent;

        private Timer timer = new Timer();
        private int showPasswordDuration = 1000;
        public frmResetPassword(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (ValidateMember(email) != 0)
            {
                if (string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                }
                else
                {     
                    Members aMember = new Members();
                    aMember.ResetPassword(ValidateMember(email), txtConfirmPassword.Text);
                    MessageBox.Show("The Password was reset. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    traverseForm(this, new frmLogIn());
                }
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmLogIn());
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
            
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';// Hide the password
            timer.Stop();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '*';
        }

        private void picLock2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
            timer.Interval = showPasswordDuration;
            timer.Start();
        }

        private void frmResetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private int ValidateMember(string email)
        {
            int MemberID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Members WHERE Email = :Email";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;

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