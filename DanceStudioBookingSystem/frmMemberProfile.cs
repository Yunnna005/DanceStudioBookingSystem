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
    public partial class frmMemberProfile : Form
    {
        public frmMemberProfile()
        {
            InitializeComponent();
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookClass fBookClass = new frmBookClass(this);
            fBookClass.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You loged out. Go to Log in.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmLogIn fLogIn = new frmLogIn();
                fLogIn.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
