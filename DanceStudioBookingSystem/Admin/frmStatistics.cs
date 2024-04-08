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
                InsertIntoChartRevenue(cboYear.Text);
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
                InsertIntoChartPopularDanceStyles();

            } else
            {
                popularDanceStyle = "No Data Found for this year";
            }

                MessageBox.Show(popularDanceStyle, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            grpChartYearlyRevenue.Visible = false;
            grpChartPopularDanceStyle.Visible = false;
        }

        private void InsertIntoChartRevenue(string selectedYear)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string strSQL = "SELECT EXTRACT(MONTH FROM Payment_Date), SUM(Price) " +
                            "FROM Bookings " +
                            "WHERE EXTRACT(YEAR FROM Payment_Date) = :selectedYear " +
                            "GROUP BY EXTRACT(MONTH FROM Payment_Date)";

            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.Parameters.Add(":selectedYear", OracleDbType.Varchar2).Value = selectedYear; // Add parameter and assign value

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                decimal[] Amounts = new decimal[12]; // Array to store revenue for each month

                for (int i = 0; i < 12; i++)
                {
                    Amounts[i] = 0;
                }

                // Populate Amounts array with revenue data
                foreach (DataRow row in dt.Rows)
                {
                    int month = Convert.ToInt32(row[0]) - 1; // Month is 1-based, but array index is 0-based
                    Amounts[month] = Convert.ToDecimal(row[1]);
                }

                // Bind chart data
                string[] Months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
                chtRevenue.Series[0].Points.DataBindXY(Months, Amounts);

                // Set chart properties
                chtRevenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtRevenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtRevenue.Series[0].LegendText = "Income in €";
                chtRevenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
                chtRevenue.Series[0].Label = "#VALY";
                chtRevenue.Titles.Add("Yearly Revenue");
                chtRevenue.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Ensure connection is closed
            }
        }
        private void InsertIntoChartPopularDanceStyles()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT Type, Qty_Of_Classes FROM Class_Types";

            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                // Arrays to store dance styles and their quantities
                string[] DanceStyles = new string[dt.Rows.Count];
                int[] Quantities = new int[dt.Rows.Count];

                // Populate arrays with data from DataTable
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DanceStyles[i] = dt.Rows[i]["Type"].ToString();
                    Quantities[i] = Convert.ToInt32(dt.Rows[i]["Qty_Of_Classes"]);
                }

                // Bind chart data
                chtPopularDanceStyles.Series[0].Points.DataBindXY(DanceStyles, Quantities);
                foreach (var point in chtPopularDanceStyles.Series[0].Points)
                {
                    point.Label = point.YValues[0].ToString(); // Set the data label to the Y value (quantity of classes)
                }
                // Set chart properties
                chtPopularDanceStyles.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtPopularDanceStyles.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtPopularDanceStyles.Series[0].LegendText = "Quantity of Classes";
                chtPopularDanceStyles.Titles.Add("Popular Dance Styles");
                chtPopularDanceStyles.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Ensure connection is closed
            }
        }
    }
}
