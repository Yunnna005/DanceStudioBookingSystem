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
            UtilFunctions.PerformMenuBook(this);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = true; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;

        }
    }
}
