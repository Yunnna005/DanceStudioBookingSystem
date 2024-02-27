using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DanceStudioBookingSystem.UtilFunctions;

namespace DanceStudioBookingSystem
{
    public partial class frmCancelClass : Form
    {
        Form parent;
        public frmCancelClass()
        {
            InitializeComponent();
            LoadTypes(cboType);
        }
        public frmCancelClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            LoadTypes(cboType);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmClassesOverview(this));
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
            if (cboType.SelectedItem == null)
            {
                MessageBox.Show("Please choose the class you want to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel class?", "Cancel Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                     
                    Classes aClass = new Classes();
                    aClass.cancelClass(FindClassID_Admin(dgvCancelClassesAdmin));

                    MessageBox.Show("The Class was canceled.\n\nThe email about canceled class was sent to all members that had it.", "Cancel Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCancelClassesAdmin.Rows.Clear();
                }
            }
        }

        private void frmCancelClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertDataGridAdminView(dgvCancelClassesAdmin, cboType);
        }
    }
}
