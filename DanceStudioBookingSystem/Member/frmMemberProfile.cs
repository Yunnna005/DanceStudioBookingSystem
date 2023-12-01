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

namespace DanceStudioBookingSystem
{
    public partial class frmMemberProfile : Form
    {
        Form parent;
        public frmMemberProfile(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            lblWriteUsername.Text = "Anna";
            lblWriteDOB.Text = "24/08/2005";
            lblWriteGender.Text = "Female";
            lblWritePhone.Text = "+353852022777";
            lblWriteEmail.Text = "anna.kovalenko@students.ittralee.ie";

            dgvClassesMember.Rows.Add("K-pop (Beginer)", "K-POP", "2023-11-26", "06:30 PM", "Ji-min Lee", "$10");
            dgvClassesMember.Rows.Add("K-pop (Intermidiate)", "K-POP", "2023-11-24", "12:30 AM", "Hyun-woo Park", "$10");
            dgvClassesMember.Rows.Add("Latin (Beginer)", "LATIN", "2023-11-27", "03:30 PM", "Rafael Lopez", "$20");
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmBookClass(this));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            PerformLogOut(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmEditMemberProfile(this));
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel class?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The class was canceled.", "Cancelled Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void frmMemberProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
