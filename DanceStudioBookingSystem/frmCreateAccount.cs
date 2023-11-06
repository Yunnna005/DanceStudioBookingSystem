using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn fLogIn = new frmLogIn();
            fLogIn.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account was created. Go to Log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            frmLogIn fLogIn = new frmLogIn();
            fLogIn.Show();
            
        }
    }
}
