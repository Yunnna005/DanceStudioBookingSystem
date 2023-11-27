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
    public partial class frmCancelClass : Form
    {
        public frmCancelClass()
        {
            InitializeComponent();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayMainMenuAdmin(this);
        }

        private void mnuStatisticsTool_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayStatistics(this);
        }

        private void tmnuScheduleClass_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayScheduleClass(this);
        }

        private void tmnuModifyClass_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayModifyClass(this);
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
    }
}
