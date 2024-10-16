﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;
using static DanceStudioBookingSystem.UtilFunctions_DB;

namespace DanceStudioBookingSystem
{
    public partial class frmBookClass : Form
    {
        Form parent;
        private int memberID;
        private int classID;
        public frmBookClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            LoadTypes(cboType);
            InsertDataToComboBox(cboMonth);
            InsertDataToComboBox(cboYearCard);
        }

        public frmBookClass(int memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            LoadTypes(cboType);
            InsertDataToComboBox(cboMonth);
            InsertDataToComboBox(cboYearCard);
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMemberProfile(memberID));
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedItem!=null)
            {
                DataGridViewRow selectedRow = dgvClasses.SelectedRows[0];

                string classIDString = selectedRow.Cells[0].Value.ToString();
                classID = int.Parse(classIDString);

                if (isAlreadyBooked(classID, memberID))
                {
                    MessageBox.Show("You already booked this class. Please choope another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pnlPayment.Visible = true;
                }   
            }
            else
            {
                MessageBox.Show("Please choose the class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        static bool isAlreadyBooked(int classID, int memberID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT COUNT(*) FROM Bookings WHERE Class_ID = :classID AND Member_ID = :memberID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.Parameters.Add("Class_ID", OracleDbType.Int32).Value = classID;
            cmd.Parameters.Add("Member_ID", OracleDbType.Int32).Value = memberID;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string validationDetails = ValidationCardDetails(txtCardNumber, txtCardHolder, cboMonth, cboYearCard, txtCVC);
            if (validationDetails.Equals("valid"))
            {
                Bookings newBook = new Bookings(txtCardHolder.Text, txtCardNumber.Text, memberID, classID);
                newBook.addBooking();

                Classes aClass = new Classes();
                aClass.UpdateAvaliablePlaces_BookProcess(classID);

                MessageBox.Show("Thank you. The class was bought.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traverseForm(this, new frmMemberProfile(memberID));
            }
            else
            {
                MessageBox.Show(validationDetails, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void frmBookClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertDataGridMemberView(dgvClasses, cboType);
        }
    }
}
