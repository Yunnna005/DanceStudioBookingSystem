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
    public partial class frmCancelClass : Form
    {
        Form parentForm;
        public frmCancelClass(Form parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMainMenuAdmin(this));
        }

        private void mnuStatisticsTool_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmStatistics(this));
        }

        private void tmnuScheduleClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmScheduleClass(this));
        }

        private void tmnuModifyClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmModifyClass(this));
        }

        private void tmnuCancelClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on this page.", "Cancel Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel class?", "Cancel Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The Class was canceled.", "Cancel Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCancelClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
