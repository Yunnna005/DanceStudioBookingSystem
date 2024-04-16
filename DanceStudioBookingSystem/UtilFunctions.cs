﻿using DanceStudioBookingSystem.Member;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DanceStudioBookingSystem
{
    class UtilFunctions
    {
        private static string gender;
        //Switch Between Forms
        public static void traverseForm(Form prevForm, Form nextForm)
        {
            nextForm.Show();
            prevForm.Hide();
        }

        //Perform Log Out, open LogIn form
        public static void PerformLogOut(Form activeForm)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You loged out. Go to Log in.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traverseForm(activeForm, new frmLogIn());
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        //Validates Member Details
        public static string ValidationMemberDetails(TextBox firstname, TextBox secondname, TextBox email, TextBox phone,
            RadioButton genderMale, RadioButton genderFemale, RadioButton genderOther, DateTimePicker dob)
        {
            DateTime selectedDate = dob.Value.Date; // Get the selected date without time
            int curentAge = DateTime.Now.Date.Year - selectedDate.Year;

            if (string.IsNullOrEmpty(firstname.Text))
            {
                firstname.Focus();
                return "Please enter valid First Name.";
            }
            else if (CheckGigits_Letters_Symbolls(firstname) != "Letters")
            {
                firstname.Focus();
                return "The Firstname must not contain numbers or symbols.";
            }
            else if (string.IsNullOrEmpty(secondname.Text))
            {
                secondname.Focus();
                return "Please enter valid Second Name.";
            }
            else if (CheckGigits_Letters_Symbolls(secondname) != "Letters")
            {
                secondname.Focus();
                return "The Secondname must not contain numbers or symbols.";
            }
            else if (string.IsNullOrEmpty(email.Text) || !Regex.IsMatch(email.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                email.Focus();
                return "Please enter valid email address";
            }
            else if (IsEmailAlreadyExists(email.Text))
            {
                email.Focus();
                return "Email already exists.";
            }
            else if (email.Text.ToLower().Contains("admin"))
            {
                email.Focus();
                return "Email cannot have word: admin.";
            }
            else if (string.IsNullOrEmpty(phone.Text) || phone.Text.Length < 12)
            {
                phone.Focus();
                return "Please enter valid phone number.";
            }
            else if (CheckGigits_Letters_Symbolls(phone) != "Digits")
            {
                phone.Focus();
                return "The phone number can not contain letters or symbols.";
            }
            else if (curentAge < 18 || curentAge > 65)
            {
                return "Your age must be between 18 and 65 included";
            }
            else
            {
                if (genderMale.Checked)
                {
                    gender = "Male";
                }
                else if (genderFemale.Checked)
                {
                    gender = "Female";

                }
                else if (genderOther.Checked)
                {
                    gender = "Other";

                }
            }
            return gender;
        }

        //Validates Member Details in frmUpdateMember
        public static string ValidationMemberDetailsForUpdate(int member_id, TextBox firstname, TextBox secondname, TextBox email, TextBox phone,
            RadioButton genderMale, RadioButton genderFemale, RadioButton genderOther, DateTimePicker dob)
        {
            DateTime selectedDate = dob.Value.Date; // Get the selected date without time
            int curentAge = DateTime.Now.Date.Year - selectedDate.Year;
            string gender = "";

            if (genderMale.Checked)
            {
                gender = "Male";
            }
            else if (genderFemale.Checked)
            {
                gender = "Female";

            }
            else if (genderOther.Checked)
            {
                gender = "Other";

            }

            if (string.IsNullOrEmpty(firstname.Text))
            {
                firstname.Focus();
                return "Please enter valid First Name.";
            }
             if (CheckGigits_Letters_Symbolls(firstname) != "Letters")
            {
                firstname.Focus();
                return "The Firstname must not contain numbers or symbols.";
            }
             if (string.IsNullOrEmpty(secondname.Text))
            {
                secondname.Focus();
                return "Please enter valid Second Name.";
            }
            if (CheckGigits_Letters_Symbolls(secondname) != "Letters")
            {
                secondname.Focus();
                return "The Secondname must not contain numbers or symbols.";
            }
            if (string.IsNullOrEmpty(email.Text) || !Regex.IsMatch(email.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                email.Focus();
                return "Please enter valid email address";
            }
            if ((!IsMemberEmail(email.Text, member_id)) && IsEmailAlreadyExists(email.Text))
            {
                email.Focus();
                return "Email already exists.";
            }
             if (email.Text.ToLower().Contains("admin"))
            {
                email.Focus();
                return "Email cannot have word: admin.";
            }
             if (string.IsNullOrEmpty(phone.Text) && phone.Text.Length < 13)
            {
                phone.Focus();
                return "Please enter valid phone number.";
            }
             if (CheckGigits_Letters_Symbolls(phone) != "Digits")
            {
                phone.Focus();
                return "The phone number can not contain letters or symbols.";
            }
             if (curentAge < 18 || curentAge > 65)
            {
                return "Your age must be between 18 and 65 included";
            }

            return gender;
        }

        //Check digits, letters, symbolls
        public static string CheckGigits_Letters_Symbolls(TextBox text)
        {
            int digits = 0, letters = 0, symbols = 0;
            if (!string.IsNullOrEmpty(text.Text))
            {
                foreach (char c in text.Text)
                {
                    if (char.IsDigit(c))
                    {
                        digits++;
                    }
                    else if (char.IsLetter(c))
                    {
                        letters++;
                    }
                    else
                    {
                        symbols++;
                    }
                }

                if (digits > 0 && letters == 0 && symbols == 0)
                {
                    return "Digits";
                }
                else if (letters > 0 && digits == 0 && symbols == 0)
                {
                    return "Letters";
                }
                else if (symbols > 0 && digits == 0 && letters == 0)
                {
                    return "Symbols";
                }
            }
            return "empty";
        }

        //Insert Data To ComboBoxes
        public static void InsertDataToComboBox(ComboBox comboBox)
        {
            if (comboBox.Name == "cboMonth")
            {
                string[] month = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
                comboBox.Items.AddRange(month);
            }
            else if (comboBox.Name == "cboYearCard")
            {
                string[] yearCard = { "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" };
                comboBox.Items.AddRange(yearCard);
            }else if(comboBox.Name == "cboYear")
            {
                string[] yearCard = {"2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034" };
                comboBox.Items.AddRange(yearCard);
            }
        }

        //Insert data to DataGrid in Member View
        public static void InsertDataGridMemberView(DataGridView datagrit, ComboBox comboBox)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string query = "SELECT * FROM Classes WHERE AvaliablePlaces > 0 AND DateCode >= TRUNC(SYSDATE)";
            OracleCommand command = new OracleCommand(query, conn);

            Classes aClass = new Classes();
            using (OracleDataReader reader = command.ExecuteReader())
            {
                datagrit.Rows.Clear();
                while (reader.Read())
                {
                    if (reader["Type_ID"].ToString() == aClass.getTypeID(comboBox.Text))
                    {
                        int instructorID = (int)reader["Instructor_ID"];
                        string instructorName = aClass.getInstructorName(instructorID);
                        string dateFormatted = ((DateTime)reader["DateCode"]).ToString("dd-MMM-yyyy");
                        datagrit.Rows.Add(reader["Class_ID"], reader["Name"], dateFormatted, reader["TimeCode"], instructorName, reader["Price"]);

                    }
                }

            }
        }

        //Insert Data to DataGrid in Admin View
        public static void InsertDataGridAdminView(DataGridView datagrit, ComboBox comboBox)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string query = "SELECT * FROM Classes";
            OracleCommand command = new OracleCommand(query, conn);

            Classes aClass = new Classes();
            using (OracleDataReader reader = command.ExecuteReader())
            {
                datagrit.Rows.Clear();
                while (reader.Read())
                {
                    if (reader["Type_ID"].ToString() == aClass.getTypeID(comboBox.Text))
                    {
                        string dateFormatted = ((DateTime)reader["DateCode"]).ToString("dd-MMM-yyyy");
                        datagrit.Rows.Add(reader["Class_ID"], reader["Name"], reader["Type_ID"], dateFormatted, reader["TimeCode"], reader["AvaliablePlaces"], reader["Capacity"], reader["Instructor_ID"], reader["Price"]);
                    }
                }

            }
        }

        //Validates Class Details
        public static string ValidClassDetails(int class_ID,TextBox name, ComboBox type, DateTimePicker date, TextBox hour, TextBox minute, ComboBox instructor, TextBox capacity, TextBox price)
        {
            DateTime selectedDate = date.Value;
            DateTime currentDate = DateTime.Now;
            string time = hour.Text + ":" + minute.Text;
            if (string.IsNullOrEmpty(name.Text))
            {
                name.Focus();
                return "Invalid class name.";
            }
            if (string.IsNullOrEmpty(type.Text))
            {
                type.Focus();
                return "Invalid type.";
            }
            if (type.SelectedItem == null)
            {
                return "Please select the type";
            }
            if (selectedDate <= currentDate.Date)
            {
                date.Focus();
                return "Selected date is in the past.";
            }
            if (string.IsNullOrEmpty(hour.Text) || hour.Text.Length != 2)
            {
                hour.Focus();
                return "The hour of the class must be in valid format and contain 2 numbers.";
            }
            if (CheckGigits_Letters_Symbolls(hour) != "Digits" || (!int.TryParse(hour.Text, out int HourValue) || HourValue > 24 || HourValue <= 1))
            {
                hour.Focus();
                return "The hour of the class must contain 2 numbers.\n\nThe hour must be between 01 and 24.";
            }
            if (string.IsNullOrEmpty(minute.Text) || minute.Text.Length != 2)
            {
                minute.Focus();
                return "The minutes of the class must be in valid format and contain 2 numbers.";
            }
            if (CheckGigits_Letters_Symbolls(minute) != "Digits" || (!int.TryParse(minute.Text, out int minuteValue) || minuteValue > 59))
            {
                minute.Focus();
                return "The minutes of the class must contain 2 numbers.\n\nThe minute must be between 00 and 59.";
            }
            if (instructor.SelectedItem == null)
            {
                return "Please choose the Instructor";
            }
            if (string.IsNullOrEmpty(capacity.Text) || (!int.TryParse(capacity.Text, out int capacityValue) || capacityValue > 30 || capacityValue <= 0))
            {
                capacity.Focus();
                return "Invalid Capacity";
            }
            if (string.IsNullOrEmpty(price.Text) || !IsValidPriceFormat(price.Text))
            {
                price.Focus();
                return "Invalid Price. Format is 00.00";
            }
            if (!IsClassScheduledBetween9_6(selectedDate, time))
            {
                return "The class must be between 9:00 and 18:00";
            }
            if (IsDateTimeAlreadyExists(selectedDate, time) && !IsClassDetails(class_ID, time, selectedDate))
            {
                return "The Date and Time already taken.";
            }
            else
            {
                return "valid";
            }
        }

        //Check Price format
        public static bool IsValidPriceFormat(string price)
        {
            string format = @"^\d{2}\.\d{2}$"; //Format 00.00
            if (Regex.IsMatch(price, format))
            {
                return true;
            }
            return false;
        }

        //Validates Card Details
        public static string ValidationCardDetails(TextBox cardNumber, TextBox cardHolder, ComboBox month, ComboBox year, TextBox cvc)
        {
            if (string.IsNullOrEmpty(cardNumber.Text) || cardNumber.Text.Length != 16)
            {
                cardNumber.Focus();
                return "Please enter a valid card number.\nThe card number must have 16 digits.";
            }
            else if (CheckGigits_Letters_Symbolls(cardNumber) != "Digits")
            {
                cardNumber.Focus();
                return "Please enter a valid card number\n (only numbers are allowed)";
            }
            else if (string.IsNullOrEmpty(cardHolder.Text) || CheckGigits_Letters_Symbolls(cardHolder) != "Letters")
            {
                cardHolder.Focus();
                return "Invalid Card Holder Name";
            }
            else if (month.SelectedItem == null)
            {
                return "Please choose the month";
            }
            else if (year.SelectedItem == null)
            {
                return "Please choose the year";
            }
            else if (string.IsNullOrEmpty(cvc.Text) || cvc.Text.Length != 3)
            {
                cvc.Focus();
                return "Invalid CVC number.";
            }
            else if (CheckGigits_Letters_Symbolls(cvc) != "Digits")
            {
                cvc.Focus();
                return "The CVC number must have only numbers.";
            }
            else
            {
                return "valid";
            }
        }

        //Display data from a DataGrid
        public static void DisplayDataFromDataGrid(DataGridView datagrid, TextBox name, ComboBox type, DateTimePicker dateTimePicker, TextBox hour, TextBox minute, ComboBox instructor,
             TextBox capacity, TextBox price)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid.SelectedRows[0];

                if (selectedRow != null)
                {
                    name.Text = selectedRow.Cells[1].Value.ToString();
                    type.Text = selectedRow.Cells[2].Value.ToString();
                    dateTimePicker.Text = selectedRow.Cells[3].Value.ToString();

                    string time = selectedRow.Cells[4].Value.ToString();
                    hour.Text = time.Substring(0, 2);
                    minute.Text = time.Substring(3, 2);

                    capacity.Text = selectedRow.Cells[6].Value.ToString();
                    instructor.Text = selectedRow.Cells[7].Value.ToString();
                    price.Text = selectedRow.Cells[8].Value.ToString();
                }
            }
        }

        //Load Types from database to comboBox 
        public static void LoadTypes(ComboBox cboType)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            string query = "SELECT Type FROM Class_Types";
            OracleCommand cmd = new OracleCommand(query, conn);

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
            string query = "SELECT FullName FROM Instructors";
            OracleCommand command = new OracleCommand(query, conn);

            using (OracleDataReader reader = command.ExecuteReader())
            {
                cboInstructors.Items.Clear();
                while (reader.Read())
                {
                    string fullName = reader.GetString(0);
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

                string query = "SELECT * FROM Members WHERE Email = :Email AND Password = :Password";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                    command.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                    using (OracleDataReader reader = command.ExecuteReader())
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

        //Finds Class ID for Admin View
        public static int FindClassID_Admin(DataGridView datagrid)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid.SelectedRows[0];

                if (selectedRow != null && selectedRow.Cells[0].Value != null)
                {
                    string classIdString = selectedRow.Cells[0].Value.ToString();

                    if (int.TryParse(classIdString, out int classId))
                    {
                        return classId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

        //Checks if email already exists in the database
        static bool IsEmailAlreadyExists(string email)
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
        static bool IsMemberEmail(string email, int memberID)
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
        static bool IsDateTimeAlreadyExists(DateTime date, string time)
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

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dbTimeCode = (string)reader["TimeCode"];

                            DateTime dbDateTime = DateTime.ParseExact($"{dateString} {dbTimeCode}", "dd-MMM-yy HH:mm", CultureInfo.InvariantCulture);

                            double hourDifference = (timeslot - dbDateTime).TotalMinutes;

                            MessageBox.Show(hourDifference.ToString());
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

        //Checks if Class scheduled between 9:00 and 18:00 
        static bool IsClassScheduledBetween9_6(DateTime date, string time)
        {
            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            DateTime classStartTime = date.AddHours(hour).AddMinutes(minute);

            DateTime startTimeBoundary = date.Date.AddHours(9); // 9:00 AM
            DateTime endTimeBoundary = date.Date.AddHours(18); // 6:00 PM

            // Check if the class start time is between 9:00 and 18:00
            bool startTimeWithinBoundary = classStartTime >= startTimeBoundary && classStartTime < endTimeBoundary;

            // Return true if class start time falls within the boundary
            return startTimeWithinBoundary;
        }

        //Calculate Revenue of the selected year
        public static float CalculateTotalPriceByYear(string selectedYear)
        {
            float totalPrice = 0;

            // Construct the SQL query to fetch classes for the selected year
            string query = "SELECT Price FROM Classes WHERE EXTRACT(YEAR FROM DateCode) = :selectedYear";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    // Bind the selected year parameter
                    command.Parameters.Add("selectedYear", OracleDbType.Varchar2).Value = selectedYear;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the result set and sum up the prices
                        while (reader.Read())
                        {
                            float classPrice = (float)reader["Price"];
                            totalPrice += classPrice;
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

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                // Iterate through the result set and accumulate the string
                while (reader.Read())
                {
                    string classType = (string)reader["Type"];
                    int qty_of_Type = Convert.ToInt32(reader["Qty_Of_Classes"]);

                    result += $"{classType}: {qty_of_Type}\n"; // Concatenating dance style type and quantity
                }
            }
            return result;
        }

        //Finds class ID
        public static int FindClassID(DataGridView dataGrid)
        {
            int classID = 0;
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                classID = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            return classID;
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

                    string SQLquery = "SELECT Booking_ID FROM Bookings WHERE Class_ID = :classID AND Member_ID = :memberID";

                    using (OracleCommand command = new OracleCommand(SQLquery, conn))
                    {
                        command.Parameters.Add(new OracleParameter("classID", classID));
                        command.Parameters.Add(new OracleParameter("memberID", memberID));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Booking ID found in the database
                                bookingID = Convert.ToInt32(reader["Booking_ID"]);
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

                string query = "SELECT * FROM Members WHERE Email = :Email";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;

                    using (OracleDataReader reader = command.ExecuteReader())
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

        //Checks Gender Box
        public static void CheckGenderBox(RadioButton male, RadioButton female, RadioButton other, string gender)
        {
            if (gender.Equals("Male"))
            {
                male.Checked = true;
            }
            else if (gender.Equals("Female"))
            {
                female.Checked = true;
            }
            else
            {
                other.Checked = true;
            }
        }

        //Finds Class Type
        public static string FindClassType(DataGridView datagrid)
        {
            string type = "";
            if (datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid.SelectedRows[0];

                type = selectedRow.Cells[2].Value.ToString();
            }
            return type;
        }

        //Insert data into chart for revenue
        public static void InsertIntoChartRevenue(string selectedYear, Chart chtRevenue)
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

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
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

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;

                    }
                }
                return false;
            }
        }
    }
}
