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
    public partial class frmStatistics : Form
    {
        Form parent;
        public frmStatistics(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            InsertDataToComboBox(cboYear);
            InsertDataToComboBox(cboYearPopularStyle);
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
            traverseForm(this, new frmCancelClass(this));
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You already on this page", "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmMainMenuAdmin(this));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (cboYear.SelectedItem != null)
            {
                string selectedYear = cboYear.SelectedItem.ToString();
                string revenue = "";

                if (selectedYear.Equals("2023"))
                {
                    revenue = "Yearly revenue is: 80000.56 $";
                }
                else if (selectedYear.Equals("2022"))
                {
                    revenue = "Yearly revenue is: 23400.456 $";
                }
                else if (selectedYear.Equals("2021"))
                {
                    revenue = "Yearly revenue is: 56400.4523 $";
                }
                else
                {
                    revenue = "No Data Found";
                }

                MessageBox.Show(revenue, "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cboYearPopularStyle.SelectedItem != null)
            {
                string selectedYear = cboYearPopularStyle.SelectedItem.ToString();
                string popularDanceStyle = "";

                if (selectedYear.Equals("2023"))
                {
                    popularDanceStyle = "The most popular dance style is Ballet\n\nStatistics of the attendance of the dance styles:" +
                        "\n\nBallet: 9065\nK-pop: 6348\nHip-Hop: 4432\nLatin: 121";
                }
                else if (selectedYear.Equals("2022"))
                {
                    popularDanceStyle = "The most popular dance style is K-pop\n\nStatistics of the attendance of the dance styles:" +
                        "\n\nK-pop: 11065\nBallet: 7648\nHip-Hop: 5432\nLatin: 331";
                }
                else if (selectedYear.Equals("2021"))
                {
                    popularDanceStyle = "The most popular dance style is Latin\n\nStatistics of the attendance of the dance styles:" +
                        "\n\nLatin: 12265\nK-pop: 9948\nHip-Hop: 7632\nBallet: 3451";
                }
                else
                {
                    popularDanceStyle = "No Data Found";
                }

                MessageBox.Show(popularDanceStyle, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
