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
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMemberProfile(this));
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = true; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int isNumeric = 0, isNOTNumeric = 0;
            if (string.IsNullOrEmpty(txtCardNumber.Text) || txtCardNumber.Text.Length<16)
            {
                MessageBox.Show("Please enter a valid card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (char c in txtCardNumber.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Please enter a valid card number (only numeric digits are allowed)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }
                traverseForm(this, new frmMemberProfile(this));
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
