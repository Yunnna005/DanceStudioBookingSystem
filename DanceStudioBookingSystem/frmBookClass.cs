using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    public partial class frmBookClass : Form
    {
        public frmBookClass() {
            InitializeComponent();
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformMenuProfile(this);
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
            MessageBox.Show("The class was booked. Go to Profile.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UtilFunctions.PerformMenuProfile(this);
        }
    }
}
