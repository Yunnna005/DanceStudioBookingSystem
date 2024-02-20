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

    public partial class frmClassesOverview : Form
    {
        public System.Windows.Forms.DataGridView dgvClassesAdmin;
        Form parent;
        public frmClassesOverview()
        {
            InitializeComponent();
        }
        public frmClassesOverview(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            frmScheduleClass scheduleClass = new frmScheduleClass(parent);
            scheduleClass.Show();
            this.Close();
        }

        private void mnutModifyClass_Click(object sender, EventArgs e)
        {
            frmModifyClass modifyClass = new frmModifyClass(parent);
            modifyClass.Show(); 
            this.Close();
        }

        private void mnutCancelClass_Click(object sender, EventArgs e)
        {
            frmCancelClass cancelClass = new frmCancelClass(parent);
            cancelClass.Show();
            this.Close();
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            frmStatistics frmStatistics = new frmStatistics(parent);
            frmStatistics.Show();
            this.Close();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            PerformLogOut(this);
        }

        private void frmMainMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Hide();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

            InsertDataGridAdminView(dgvClassesAdmin, cboType);
        }

        private void mnuDBConnect_Click(object sender, EventArgs e)
        {
            frmDBConnect frmDBConnect = new frmDBConnect(parent);
            frmDBConnect.Show();
            this.Close();
        }
    }
}
