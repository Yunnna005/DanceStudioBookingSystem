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
    public partial class frmStatistics : Form
    {
        Form parent;
        public frmStatistics(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
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
            traverseForm(this, new frmCancelClass(this));
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You already on this page", "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMainMenuAdmin(this));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yearly revenue is: 10000$", "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The most popular dance style is Ballet\n\nStatistics of the addendance of other styles:", "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
