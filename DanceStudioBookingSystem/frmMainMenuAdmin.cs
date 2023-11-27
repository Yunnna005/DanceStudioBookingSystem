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
    public partial class frmMainMenuAdmin : Form
    {
        public frmMainMenuAdmin()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            UtilFunctions.DisplayScheduleClass(this);
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

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformLogOut(this);
        }


        public void RefreshDataGridView()
        {
            dgvClassesAdmin.Rows.Clear();

            foreach (ClassInfo classInfo in ClassDataStorage.Classes)
            {
                dgvClassesAdmin.Rows.Add(
                    classInfo.Name,
                    classInfo.Type,
                    classInfo.Date,
                    classInfo.Time,
                    classInfo.Instructor,
                    classInfo.Capacity,
                    classInfo.Price
                );
            }
        }
    }
}
