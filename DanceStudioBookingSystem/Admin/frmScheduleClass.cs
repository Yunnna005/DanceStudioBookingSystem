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
    public partial class frmScheduleClass : Form
    {
        Form parent;
        public frmScheduleClass()
        {
            InitializeComponent();
        }
        public frmScheduleClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on this page.", "Schedule Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            frmClassesOverview frmClassesOverview = new frmClassesOverview(parent);
            frmClassesOverview.Show();
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidClassDetails(txtName,cboType,txtHour,txtMinute, cboInstructor, txtCapacity, txtPrice).Equals("valid")) 
            {

                int capacity = int.Parse(txtCapacity.Text);
                int price = int.Parse(txtPrice.Text);

                Classes aClass = new Classes(txtName.Text, getTypeID(), dtpDate.Value, txtHour.Text, txtMinute.Text, getInstructorID(), capacity, price);
                aClass.addClass();

                MessageBox.Show("The class was created", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmClassesOverview frmClassesOverview = new frmClassesOverview(parent);
                frmClassesOverview.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(ValidClassDetails(txtName, cboType, txtHour, txtMinute, cboInstructor, txtCapacity, txtPrice), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private int getInstructorID()
        {
            throw new NotImplementedException();
        }

        private string getTypeID()
        {
            throw new NotImplementedException();
        }

        private void frmScheduleClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Hide();
        }
    }
}
