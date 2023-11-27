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
        public frmScheduleClass()
        {
            InitializeComponent();
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on this page.", "Schedule Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnutModifyClass_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayModifyClass(this);
        }

        private void mnutCancelClass_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the data from the text boxes
            string name = txtName.Text;
            string type = txtType.Text;
            DateTime date = dtpDate.Value;
            string time = txtTime.Text;
            string instructor = txtInstructor.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);

            // Create a new ClassInfo object
            ClassInfo newClass = new ClassInfo
            {
                Name = name,
                Type = type,
                Date = date,
                Time = time,
                Instructor = instructor,
                Capacity = capacity,
                Price = price
            };

            MessageBox.Show("The class was created", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add the new class to the storage
            ClassDataStorage.Classes.Add(newClass);

            // Refresh the DataGridView in frmMainMenuAdmin
            RefreshDataGridViewInMainMenuAdmin();

            frmMainMenuAdmin frmMainMenuAdmin = new frmMainMenuAdmin();
            this.Hide();
            frmMainMenuAdmin.Show();
        }

        private void RefreshDataGridViewInMainMenuAdmin()
        {
            if (Application.OpenForms["frmMainMenuAdmin"] is frmMainMenuAdmin mainMenuAdmin)
            {
                mainMenuAdmin.RefreshDataGridView();
            }
        }
    }
    
}
