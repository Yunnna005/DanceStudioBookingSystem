using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;

namespace DanceStudioBookingSystem
{
    public partial class frmStatistics : Form
    {
        Form parent;
        public frmStatistics()
        {
            InitializeComponent();
        }
        public frmStatistics(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            InsertDataToComboBox(cboYear);

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
            traverseForm(this, new frmClassesOverview(this));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var revenue_text = "";
            if (cboYear.SelectedItem != null)
            {
                grpChartYearlyRevenue.Visible = true;
                InsertIntoChartRevenue(cboYear.Text, chtRevenue);
                float revenue = CalculateTotalPriceByYear(cboYear.Text);
                if(revenue != 0)
                {
                    revenue_text = "The yearly revenue is: " + revenue;
                }
                else
                {
                    revenue_text = "No Data Found for this year";
                }
               
                MessageBox.Show(revenue_text, "Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string popularDanceStyle = "";

            if (PopularDanceStyles() != null)
            {
                popularDanceStyle = PopularDanceStyles();
                grpChartPopularDanceStyle.Visible = true;
                InsertIntoChartPopularDanceStyles(chtPopularDanceStyles);

            } else
            {
                popularDanceStyle = "No Data Found for this year";
            }

            MessageBox.Show(popularDanceStyle, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            grpChartYearlyRevenue.Visible = false;
            grpChartPopularDanceStyle.Visible = false;
        } 
    }
}
