using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;

namespace DanceStudioBookingSystem
{
    public partial class frmBookClass : Form
    {
        Form parent;
        private int memberID;
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
                pnlPayment.Visible = true;
            }
            else
            {
                MessageBox.Show("Please choose the class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (ValidationCardDetails(txtCardNumber, txtCardHolder, cboMonth, cboYearCard, txtCVC)=="valid")
            {
                long cardNumber = long.Parse(txtCardNumber.Text);
                Bookings newBook = new Bookings(txtCardHolder.Text, cardNumber, memberID, FindClassID(dgvClasses));
                newBook.addBooking();

                MessageBox.Show("Thank you. The class was bought.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traverseForm(this, new frmMemberProfile(memberID));
            }
            else
            {
                MessageBox.Show(ValidationCardDetails(txtCardNumber, txtCardHolder, cboMonth, cboYearCard, txtCVC), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void frmBookClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertDataGridMemberView(dgvClasses, cboType);
        }

        private void frmBookClass_Load(object sender, EventArgs e)
        {

        }
    }
}
