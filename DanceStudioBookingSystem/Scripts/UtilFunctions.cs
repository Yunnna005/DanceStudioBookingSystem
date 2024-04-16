using DanceStudioBookingSystem.Member;
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
using static DanceStudioBookingSystem.UtilFunctions_DB;

namespace DanceStudioBookingSystem
{
    class UtilFunctions
    {
        //Switch Between Forms
        public static void traverseForm(Form prevForm, Form nextForm)
        {
            nextForm.Show();
            prevForm.Hide();
        }

        //Validates Member Details
        public static string ValidationMemberDetails(int member_id, TextBox firstname, TextBox secondname, TextBox email, TextBox phone, DateTimePicker dob)
        {
            DateTime selectedDate = dob.Value.Date; // Get the selected date without time
            int curentAge = DateTime.Now.Date.Year - selectedDate.Year;

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
            if ((!IsMemberEmail(email.Text.ToLower(), member_id)) && IsEmailAlreadyExists(email.Text.ToLower()))
            {
                email.Focus();
                return "Email already exists.";
            }
             if (email.Text.ToLower().Contains("admin"))
            {
                email.Focus();
                return "Email cannot have word: admin.";
            }
             if (phone.Text.Length < 12)
            {
                phone.Focus();
                return "Please enter valid phone number (12 digits).";
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

            return "valid";
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
                string[] yearCard = { "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" };
                comboBox.Items.AddRange(yearCard);
            }else if(comboBox.Name == "cboYear")
            {
                string[] yearCard = {"2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034" };
                comboBox.Items.AddRange(yearCard);
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
        public static string GetGender(RadioButton male, RadioButton female, RadioButton other)
        {
            if (male.Checked)
            {
                return "Male";
            }
            if (female.Checked)
            {
                return "Female";
            }
            if (other.Checked)
            {
                return "Other";
            }
            return "The gender does not select";
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
    }
}
