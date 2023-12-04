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
        public frmScheduleClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            InsertDataToComboBox(cboTime);
            InsertDataToComboBox(cboInstructor);
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
            traverseForm(this, new frmMainMenuAdmin(this));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) 
            {
                MessageBox.Show("Invalid class name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show("Invalid type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
            }
            else if (cboTime.SelectedItem == null)
            {
                MessageBox.Show("Choose Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (cboInstructor.SelectedItem == null)
            {
                MessageBox.Show("Choose Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCapacity.Text) || !int.TryParse(txtCapacity.Text, out int capacityValue) || capacityValue > 30 || capacityValue <= 0)
            {
                MessageBox.Show("Invalid Capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacity.Focus();
            }
            else if (string.IsNullOrEmpty(txtPrice.Text) || !IsValidPriceFormat(txtPrice.Text))
            {
                MessageBox.Show("Invalid Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
            }
            else
            {
                MessageBox.Show("The class was created", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traverseForm(this, new frmMainMenuAdmin(this));
            } 
        }

        private void frmScheduleClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
