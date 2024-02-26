﻿using DanceStudioBookingSystem.Member;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DanceStudioBookingSystem
{
    public partial class frmScheduleClass : Form
    {
        Form parent;
        public frmScheduleClass()
        {
            InitializeComponent();
            LoadTypes(cboType);
            Loadnstructors(cboInstructor);
        }
        public frmScheduleClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            LoadTypes(cboType);
            Loadnstructors(cboInstructor);
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on this page.", "Schedule Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmClassesOverview(this));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidClassDetails(txtName, cboType, txtHour, txtMinute, cboInstructor, txtCapacity, txtPrice).Equals("valid"))
            {

                int capacity = int.Parse(txtCapacity.Text);
                float price = float.Parse(txtPrice.Text);

                Classes aClass = new Classes(txtName.Text, cboType, dtpDate.Value, txtHour.Text, txtMinute.Text, cboInstructor, capacity, price);
                aClass.addClass();

                MessageBox.Show("The class was created", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                traverseForm(this, new frmClassesOverview(this));
            }
            else
            {
                MessageBox.Show(ValidClassDetails(txtName, cboType, txtHour, txtMinute, cboInstructor, txtCapacity, txtPrice), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmScheduleClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
