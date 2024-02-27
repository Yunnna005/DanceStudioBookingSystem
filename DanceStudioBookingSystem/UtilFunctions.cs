﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DanceStudioBookingSystem
{
    class UtilFunctions
    {
        private static string gender;
        public static void traverseForm(Form prevForm, Form nextForm)
        {
                nextForm.Show();
                prevForm.Hide();
        }

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
            else if (string.IsNullOrEmpty(phone.Text) || phone.Text.Length < 12)
            {
                phone.Focus();
                return "Please enter valid phone number.";
            }else if (CheckGigits_Letters_Symbolls(phone) != "Digits")
            {
                phone.Focus();
                return "The phone number can not contain letters or symbols.";
            }
            else if (curentAge<18 || curentAge > 65)
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
               
                if (digits > 0 && letters == 0 && symbols==0) 
                {
                    return "Digits";
                }
                else if(letters > 0 && digits == 0 && symbols == 0)
                {
                    return "Letters";
                }else if (symbols>0 && digits == 0 && letters == 0)
                {
                    return "Symbols";
                }
            }
            return "empty";
        }

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
            }
        }

        public static void InsertDataGridMemberView(DataGridView datagrit, ComboBox comboBox)
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
                        int instructorID = (int)reader["Instructor_ID"];
                        string instructorName = aClass.getInstructorName(instructorID);
                        datagrit.Rows.Add(reader["Name"], reader["DateCode"], reader["TimeCode"], instructorName, reader["Price"]);
                    }
                }

            }
        }

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
                        datagrit.Rows.Add(reader["Class_ID"], reader["Name"], reader["Type_ID"], reader["DateCode"], reader["TimeCode"], reader["AvaliablePlaces"], reader["Capacity"], reader["Instructor_ID"], reader["Price"]);
                    }
                }

            }
        }

        public static string ValidClassDetails(TextBox name, ComboBox type, TextBox hour, TextBox minute, ComboBox instructor, TextBox capacity, TextBox price)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                name.Focus();
                return "Invalid class name";
            }
            else if (string.IsNullOrEmpty(type.Text))
            {
                type.Focus();
                return "Invalid type";
            }else if (type.SelectedItem == null)
            {
                return "Please select the type";
            }
            else if (string.IsNullOrEmpty(hour.Text) || hour.Text.Length != 2)
            {
                hour.Focus();
                return "The hour of the class must be in valid format and contain 2 numbers.";
            }else if (CheckGigits_Letters_Symbolls(hour) != "Digits" || (!int.TryParse(hour.Text, out int HourValue) || HourValue > 12 || HourValue <= 1))
            {
                hour.Focus();
                return "The hour of the class must contain 2 numbers.\n\nThe hour must be between 1 and 12.";
            }
            else if (string.IsNullOrEmpty(minute.Text) || minute.Text.Length != 2)
            {
                minute.Focus();
                return "The minutes of the class must be in valid format and contain 2 numbers.";
            }else if (CheckGigits_Letters_Symbolls(minute) != "Digits" || (!int.TryParse(minute.Text, out int minuteValue) || minuteValue > 59 ))
            {
                minute.Focus();
                return "The minutes of the class must contain 2 numbers.\n\nThe minute must be between 0 and 59.";
            }
            else if (instructor.SelectedItem == null)
            {
                return "Please choose the Instructor";
            }
            else if (string.IsNullOrEmpty(capacity.Text) || (!int.TryParse(capacity.Text, out int capacityValue) || capacityValue > 30 || capacityValue <= 0))
            {
                capacity.Focus();
                return "Invalid Capacity";
            }
            else if (string.IsNullOrEmpty(price.Text) || !IsValidPriceFormat(price.Text))
            {
                price.Focus();
                return "Invalid Price. Format is 00.00";
            }
            else
            {
                return "valid";
            }
        }

        public static bool IsValidPriceFormat(string price)
        {
            string format = @"^\d{2}\.\d{2}$"; //Format 00.00
            if (Regex.IsMatch(price, format))
            {
                return true;
            }
            return false;
        }

        public static string ValidationCardDetails(TextBox cardNumber, TextBox cardHolder, ComboBox month, ComboBox year, TextBox cvc)
        {
            if (string.IsNullOrEmpty(cardNumber.Text) || cardNumber.Text.Length != 16)
            {
                cardNumber.Focus();
                return "Please enter a valid card number.\nThe card number must have 16 digits.";
            } else if (CheckGigits_Letters_Symbolls(cardNumber) != "Digits")
            {
                cardNumber.Focus();
                return "Please enter a valid card number\n (only numbers are allowed)";
            } else if (string.IsNullOrEmpty(cardHolder.Text) || CheckGigits_Letters_Symbolls(cardHolder) != "Letters")
            {
                cardHolder.Focus();
                return "Invalid Card Holder Name";
            } else if (month.SelectedItem == null)
            {
                return "Please choose the month";
            } else if (year.SelectedItem == null)
            {
                return "Please choose the year";
            } else if (string.IsNullOrEmpty(cvc.Text) || cvc.Text.Length != 3)
            {
                cvc.Focus();
                return "Invalid CVC number.";
            }else if (CheckGigits_Letters_Symbolls(cvc) != "Digits")
            {
                cvc.Focus();
                return "The CVC number must have only numbers.";
            }
            else
            {
                return "valid";
            }
        }

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

        public static void Loadnstructors(ComboBox cboInstructors)
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

        public static int FindClassID(DataGridView datagrid)
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
    }
}
