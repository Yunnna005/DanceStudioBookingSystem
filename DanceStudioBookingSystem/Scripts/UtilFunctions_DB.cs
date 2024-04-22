using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DanceStudioBookingSystem
{
    class UtilFunctions_DB
    {
        //Load Types from database to comboBox 
        public static void LoadTypes(ComboBox cboType)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT Type FROM Class_Types";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                cboType.Items.Clear();

                while (dr.Read())
                {
                    string itemName = dr.GetString(0);
                    cboType.Items.Add(itemName);
                }
            }
        }

        //Load Instructors from database to comboBox
        public static void LoadInstructors(ComboBox cboInstructors)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT FullName FROM Instructors";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                cboInstructors.Items.Clear();
                while (dr.Read())
                {
                    string fullName = dr.GetString(0);
                    cboInstructors.Items.Add(fullName);
                }
            }
        }

        //Finds member ID
        public static int FindMemberID(string email, string password)
        {
            int MemberID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM Members WHERE Email = :Email AND Password = :Password";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MemberID = (int)reader["Member_ID"];
                        }
                    }
                    return 0;
                }
            }
        }

        //Insert data to DataGrid in Member View
        public static void InsertDataGridMemberView(DataGridView datagrit, ComboBox comboBox)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT * FROM Classes WHERE AvaliablePlaces > 0 AND DateCode >= TRUNC(SYSDATE)";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            Classes aClass = new Classes();
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                datagrit.Rows.Clear();
                while (dr.Read())
                {
                    if (dr["Type_ID"].ToString() == aClass.getTypeID(comboBox.Text))
                    {
                        int instructorID = (int)dr["Instructor_ID"];
                        string instructorName = aClass.getInstructorName(instructorID);
                        string dateFormatted = ((DateTime)dr["DateCode"]).ToString("dd-MMM-yyyy");
                        datagrit.Rows.Add(dr["Class_ID"], dr["Name"], dateFormatted, dr["TimeCode"], instructorName, dr["Price"]);
                    }
                }
            }
        }

        //Insert Data to DataGrid in Admin View
        public static void InsertDataGridAdminView(DataGridView datagrit, ComboBox comboBox)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT * FROM Classes";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            Classes aClass = new Classes();
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                datagrit.Rows.Clear();
                while (dr.Read())
                {
                    if (dr["Type_ID"].ToString() == aClass.getTypeID(comboBox.Text))
                    {
                        string dateFormatted = ((DateTime)dr["DateCode"]).ToString("dd-MMM-yyyy");
                        datagrit.Rows.Add(dr["Class_ID"], dr["Name"], dr["Type_ID"], dateFormatted, dr["TimeCode"], dr["AvaliablePlaces"], dr["Capacity"], dr["Instructor_ID"], dr["Price"]);
                    }
                }
            }
        }
        //Checks if email already exists in the database
        public static bool IsEmailAlreadyExists(string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT COUNT(*) FROM Members WHERE Email = :Email";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }

        //Checks if member insert the same email that they already have
        public static bool IsMemberEmail(string email, int memberID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT COUNT(*) FROM Members WHERE Email = :Email AND Member_ID = :memberID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("Member_ID", OracleDbType.Varchar2).Value = memberID;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count == 1;
                }
            }
        }

        //Checks if date and time of this date already exists in the database
        public static bool IsDateTimeAlreadyExists(DateTime date, string time)
        {
            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            DateTime timeslot = date.AddHours(hour).AddMinutes(minute);

            string dateString = timeslot.ToString("dd-MMM-yy");

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM Classes WHERE DateCode = :dateString";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("dateString", dateString);

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string dbTimeCode = (string)dr["TimeCode"];

                            DateTime dbDateTime = DateTime.ParseExact($"{dateString} {dbTimeCode}", "dd-MMM-yy HH:mm", CultureInfo.InvariantCulture);

                            double hourDifference = (timeslot - dbDateTime).TotalMinutes;

                            if (Math.Abs(hourDifference) <= 59)
                            {
                                return true; // Conflicting time slot found
                            }
                        }
                    }
                }
            }
            return false; // No conflicting time slots found
        }

        //Calculate Revenue of the selected year
        public static float CalculateTotalPriceByYear(string selectedYear)
        {
            float totalPrice = 0;
            string sqlQuery = "SELECT SUM(Price) AS TotalPrice FROM Bookings WHERE EXTRACT(YEAR FROM Payment_Date) = :selectedYear";
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("selectedYear", OracleDbType.Varchar2).Value = selectedYear;

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() && dr["TotalPrice"] != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(dr["TotalPrice"]);
                        }
                    }
                }
            }
            return totalPrice;
        }

        //Finds popular dance styles
        public static string PopularDanceStyles()
        {
            string result = "";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT Type, Qty_Of_Classes FROM Class_Types";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            using (OracleDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string classType = (string)rd["Type"];
                    int qty_of_Type = Convert.ToInt32(rd["Qty_Of_Classes"]);

                    result += $"{classType}: {qty_of_Type}\n"; // Concatenating dance style type and quantity
                }
            }
            return result;
        }

        //Finds booking id
        public static int FindBookingID(int memberID, DataGridView dgvClassesMember)
        {
            int bookingID = 0;
            int classID = 0;

            if (dgvClassesMember.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClassesMember.SelectedRows[0];

                classID = Convert.ToInt32(selectedRow.Cells[0].Value);

                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT Booking_ID FROM Bookings WHERE Class_ID = :classID AND Member_ID = :memberID";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("classID", classID));
                        cmd.Parameters.Add(new OracleParameter("memberID", memberID));

                        using (OracleDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                // Booking ID found in the database
                                bookingID = Convert.ToInt32(rd["Booking_ID"]);
                            }
                            else
                            {
                                MessageBox.Show("Booking not found in the database.");
                            }
                        }
                    }
                }
            }
            return bookingID;
        }

        //Finds Member ID using email
        public static int ValidateMember(string email)
        {
            int MemberID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM Members WHERE Email = :Email";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;

                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return MemberID = (int)rd["Member_ID"];
                        }
                    }
                    return 0;
                }
            }
        }

        //Insert data into chart for revenue
        public static void InsertIntoChartRevenue(string selectedYear, Chart chtRevenue)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT EXTRACT(MONTH FROM Payment_Date), SUM(Price) " +
                            "FROM Bookings " +
                            "WHERE EXTRACT(YEAR FROM Payment_Date) = :selectedYear " +
                            "GROUP BY EXTRACT(MONTH FROM Payment_Date)";

            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(":selectedYear", OracleDbType.Varchar2).Value = selectedYear; // Add parameter and assign value

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                decimal[] Amounts = new decimal[12]; // Array to store revenue for each month

                for (int i = 0; i < 12; i++)
                {
                    Amounts[i] = 0;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int month = Convert.ToInt32(row[0]) - 1;
                    Amounts[month] = Convert.ToDecimal(row[1]);
                }

                string[] Months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
                chtRevenue.Series[0].Points.DataBindXY(Months, Amounts);

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
                conn.Close();
            }
        }

        //Insert data into a chart for popular dance styles
        public static void InsertIntoChartPopularDanceStyles(Chart chtPopularDanceStyles)
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

                string[] DanceStyles = new string[dt.Rows.Count];
                int[] Quantities = new int[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DanceStyles[i] = dt.Rows[i]["Type"].ToString();
                    Quantities[i] = Convert.ToInt32(dt.Rows[i]["Qty_Of_Classes"]);
                }

                chtPopularDanceStyles.Series[0].Points.DataBindXY(DanceStyles, Quantities);
                foreach (var point in chtPopularDanceStyles.Series[0].Points)
                {
                    point.Label = point.YValues[0].ToString();
                }

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
                conn.Close();
            }
        }
        public static bool IsClassDetails(int classID, string time, DateTime date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT DateCode, TimeCode FROM Classes WHERE Class_ID = :Class_ID AND DateCode = :DateCode AND TimeCode = :TimeCode";
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {

                cmd.Parameters.Add("Class_ID", OracleDbType.Int32).Value = classID;
                cmd.Parameters.Add("DateCode", OracleDbType.Date).Value = date;
                cmd.Parameters.Add("TimeCode", OracleDbType.Varchar2).Value = time;

                using (OracleDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public static bool IsMemberPassword(int memberID, string password)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT Password FROM Members WHERE Member_ID = :memberID AND Password = :password";
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("Member_ID", OracleDbType.Int32).Value = memberID;
                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                using (OracleDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool IsBookedClass(int memberID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string sqlQuery = "SELECT Member_Id FROM Bookings WHERE Member_ID = :memberID";
            using(OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("Member_ID", memberID);

                using(OracleDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
