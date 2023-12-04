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
        public frmBookClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            InsertDataToComboBox(cboType);
            InsertDataToComboBox(cboMonth);
            InsertDataToComboBox(cboYearCard);
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMemberProfile(this));
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
                MessageBox.Show("Thank you. The class was bought.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traverseForm(this, new frmMemberProfile(this));
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
    }
}
