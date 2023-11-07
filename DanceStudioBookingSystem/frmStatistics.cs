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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
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
            UtilFunctions.DisplayCancelClass(this);
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayStatistics(this);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayMainMenuAdmin(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yearly revenue is: 10000$", "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The most popular dance style is Ballet\n\nStatistics of the addendance of other styles:", "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
