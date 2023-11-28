﻿using System;
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

    public partial class frmMainMenuAdmin : Form
    {
        public System.Windows.Forms.DataGridView dgvClassesAdmin;
        Form parent;
        public frmMainMenuAdmin(Form parentForm)
        {

            parent = parentForm;
            InitializeComponent();
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmScheduleClass(this));
        }

        private void mnutModifyClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmModifyClass(this));
        }

        private void mnutCancelClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmCancelClass(this));
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmStatistics(this));
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            PerformLogOut(this);
        }

        private void frmMainMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
