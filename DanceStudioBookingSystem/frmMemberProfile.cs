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
    public partial class frmMemberProfile : Form
    {
        public frmMemberProfile()
        {
            InitializeComponent();
            lblWriteUsername.Text = "Anna";
            lblWriteDOB.Text = "24/08/2005";
            lblWriteGender.Text = "Female";
            lblWritePhone.Text = "+353852022777";
            lblWriteEmail.Text = "anna.kovalenko@students.ittralee.ie";
            InsertDataIntoDataGridView();
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformMenuBook(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformLogOut(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditMemberProfile fEditProfile = new frmEditMemberProfile();
            fEditProfile.Show();
        }

        private void InsertDataIntoDataGridView()
        {
            List<List<string>> MemberClassesDataList = new List<List<string>>()
                {
                    new List<string> { "K-pop (Advance)", "2023-11-24", "10:00 AM", "Ji-min Lee", "$15" },
                    new List<string> { "Latin (Intermidiate)", "2023-11-25", "02:30 PM", "Isabella Martinez", "$25" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-25", "03:30 PM", "Jasmine Williams", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-26", "02:30 PM", "Malik Johnson", "$15" },
                 };

            foreach (var rowData in MemberClassesDataList)
            {
                dgvClasses.Rows.Add(rowData.ToArray());
            }
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel class?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The class was canceled.", "Cancelled Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
