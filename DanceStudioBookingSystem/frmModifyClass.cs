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
    public partial class frmModifyClass : Form
    {
        Form parent;
        public frmModifyClass(Form parentForm)
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
            MessageBox.Show("You are already on this page.", "Modify Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnutCancelClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmCancelClass(this));
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmStatistics(this));
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMainMenuAdmin(this));
        }

        private void frmModifyClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
