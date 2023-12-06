using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            else if (string.IsNullOrEmpty(email.Text) || !Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                email.Focus();
                return "Please enter valid email address";
            }
            else if (string.IsNullOrEmpty(phone.Text) || phone.Text.Length < 9)
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
               
                if (digits > 0 && letters == 0 && symbols==0) // string has only digits
                {
                    return "Digits";
                }
                else if(letters > 0 && digits == 0 && symbols == 0)// string has only letters
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
            if (comboBox.Name == "cboType")
            {
                string[] types = { "All","K-pop","Latin","Ballet","Hip-Hop"};
                comboBox.Items.AddRange(types);
            }else if(comboBox.Name == "cboTime")
            {
                string[] time = { "AM","PM"};
                comboBox.Items.AddRange(time);
            }else if (comboBox.Name == "cboInstructor")
            {
                string[] instructors = {"Hyun-Woo Park","Isabella Martinez","Jasmine Williams","Ji-Min Lee","Malik Johnson","Olivia Smith",
                    "Rafael Lopez","Soo-Jin Kim","Xavier Ortiz"};
                comboBox.Items.AddRange(instructors);
            }else if (comboBox.Name == "cboYear" || comboBox.Name == "cboYearPopularStyle")
            {
                string[] year = {"2018","2019","2020","2021","2022","2023"};
                comboBox.Items.AddRange(year);
            }else if (comboBox.Name == "cboMonth")
            {
                string[] month = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
                comboBox.Items.AddRange(month);
            }else if (comboBox.Name == "cboYearCard")
            {
                string[] yearCard = { "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" };
                comboBox.Items.AddRange(yearCard);
            }
            
        }

        public static void InsertDataGridMemberView(DataGridView datagrit, ComboBox comboBox)
        {
            datagrit.Rows.Clear();

            List<List<string>> kpopDataList = new List<List<string>>()
                {
                    new List<string> { "K-pop (Advance)", "2023-11-24", "10:00 AM", "Ji-min Lee", "$15" },
                    new List<string> { "K-pop (Intermidiate)", "2023-11-25", "02:30 PM", "Hyun-woo Park", "$15" },
                    new List<string> { "K-pop (Beginer)", "2023-11-27", "04:30 PM", "Soo-jin Kim", "$10" },
                    new List<string> { "K-pop (Beginer)", "2023-11-26", "06:30 PM", "Ji-min Lee", "$10" },
                    new List<string> { "K-pop (Intermidiate)", "2023-11-24", "12:30 AM", "Hyun-woo Park", "$10" },
                };

            List<List<string>> latinDataList = new List<List<string>>()
                {
                    new List<string> { "Latin (Advance)", "2023-11-24", "11:00 AM", "Rafael Lopez", "$25" },
                    new List<string> { "Latin (Intermidiate)", "2023-11-25", "02:30 PM", "Isabella Martinez", "$25" },
                    new List<string> { "Latin (Beginer)", "2023-11-27", "03:30 PM", "Rafael Lopez", "$20" },
                };

            List<List<string>> BalletDataList = new List<List<string>>()
                {
                    new List<string> { "Ballet (Advance)", "2024-01-24", "11:00 AM", "Olivia Smith", "$35" },

                };

            List<List<string>> HipHopDataList = new List<List<string>>()
                {
                    new List<string> { "HipHop (Advance)", "2023-11-24", "10:00 AM", "Xavier Ortiz", "$15" },
                    new List<string> { "HipHop (Advance)", "2023-11-25", "10:00 AM", "Jasmine Williams", "$15" },
                    new List<string> { "HipHop (Advance)", "2023-11-25", "11:00 AM", "Ji-min Lee", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-25", "02:30 PM", "Xavier Ortiz", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-25", "03:30 PM", "Jasmine Williams", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-26", "02:30 PM", "Malik Johnson", "$15" },
                    new List<string> { "HipHop (Beginer)", "2023-11-26", "04:30 PM", "Soo-jin Kim", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-26", "06:30 PM", "Xavier Ortiz", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-27", "01:30 PM", "Jasmine Williams", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-27", "02:30 PM", "Malik Johnson", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "12:30 AM", "Hyun-woo Park", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "11:30 AM", "Malik Johnson", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "10:30 AM", "Xavier Ortiz", "$10" },

                };

            if (comboBox.SelectedIndex == 1)
            {
                foreach (var rowData in kpopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 2)
            {
                foreach (var rowData in latinDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 3)
            {
                foreach (var rowData in BalletDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 4)
            {
                foreach (var rowData in HipHopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }else if (comboBox.SelectedIndex == 0)
            {
                foreach (var rowData in kpopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in latinDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in BalletDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in HipHopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
        }

        public static void InsertDataGridAdminView(DataGridView datagrit, ComboBox comboBox)
        {
            datagrit.Rows.Clear();
            List<List<string>> kpopDataList = new List<List<string>>()
                {
                    new List<string> { "K-pop (Advance)","K-POP", "2023-11-24", "10:00 AM", "Ji-min Lee","25", "$15" },
                    new List<string> { "K-pop (Intermidiate)", "K-POP", "2023-11-25", "02:30 PM", "Hyun-woo Park", "25", "$15" },
                    new List<string> { "K-pop (Beginer)", "K-POP", "2023-11-27", "04:30 PM", "Soo-jin Kim", "25", "$10" },
                    new List<string> { "K-pop (Beginer)", "K-POP", "2023-11-26", "06:30 PM", "Ji-min Lee", "25", "$10" },
                    new List<string> { "K-pop (Intermidiate)", "K-POP", "2023-11-24", "12:30 AM", "Hyun-woo Park", "25", "$10" },
                };

            List<List<string>> latinDataList = new List<List<string>>()
                {
                    new List<string> { "Latin (Advance)","LATIN", "2023-11-24", "11:00 AM", "Rafael Lopez","15", "$25" },
                    new List<string> { "Latin (Intermidiate)", "LATIN", "2023-11-25", "02:30 PM", "Isabella Martinez", "15", "$25" },
                    new List<string> { "Latin (Beginer)", "LATIN", "2023-11-27", "03:30 PM", "Rafael Lopez", "15", "$20" },
                };

            List<List<string>> BalletDataList = new List<List<string>>()
                {
                    new List<string> { "Ballet (Advance)","BALLET", "2024-01-24", "11:00 AM", "Olivia Smith","10", "$35" },

                };

            List<List<string>> HipHopDataList = new List<List<string>>()
                {
                    new List<string> { "Hip-Hop (Advance)","HIP-HOP", "2023-11-24", "10:00 AM", "Xavier Ortiz", "25", "$15" },
                    new List<string> { "Hip-Hop (Advance)", "HIP-HOP", "2023-11-25", "10:00 AM", "Jasmine Williams", "25", "$15" },
                    new List<string> { "Hip-Hop (Advance)", "HIP-HOP", "2023-11-25", "11:00 AM", "Ji-min Lee", "25", "$15" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-25", "02:30 PM", "Xavier Ortiz", "25", "$15" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-25", "03:30 PM", "Jasmine Williams", "25", "$15" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-26", "02:30 PM", "Malik Johnson", "25", "$15" },
                    new List<string> { "Hip-Hop (Beginer)", "HIP-HOP", "2023-11-26", "04:30 PM", "Soo-jin Kim", "25", "$10" },
                    new List<string> { "Hip-Hop (Beginer)", "HIP-HOP", "2023-11-26", "06:30 PM", "Xavier Ortiz", "25", "$10" },
                    new List<string> { "Hip-Hop (Beginer)", "HIP-HOP", "2023-11-27", "01:30 PM", "Jasmine Williams", "25", "$10" },
                    new List<string> { "Hip-Hop (Beginer)", "HIP-HOP", "2023-11-27", "02:30 PM", "Malik Johnson", "25", "$10" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-28", "12:30 AM", "Hyun-woo Park", "25", "$10" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-28", "11:30 AM", "Malik Johnson", "25", "$10" },
                    new List<string> { "Hip-Hop (Intermidiate)", "HIP-HOP", "2023-11-28", "10:30 AM", "Xavier Ortiz", "25", "$10" },

                };
            if (comboBox.SelectedIndex == 1)
            {
                foreach (var rowData in kpopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 2)
            {
                foreach (var rowData in latinDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 3)
            {
                foreach (var rowData in BalletDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
            else if (comboBox.SelectedIndex == 4)
            {
                foreach (var rowData in HipHopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }else if (comboBox.SelectedIndex == 0)
            {
                foreach (var rowData in kpopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in latinDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in BalletDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
                foreach (var rowData in HipHopDataList)
                {
                    datagrit.Rows.Add(rowData.ToArray());
                }
            }
        }

        public static string ValidClassDetails(TextBox name, TextBox type, TextBox hour, TextBox minute, ComboBox time, ComboBox instructor, TextBox capacity, TextBox price)
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
            }else if (CheckGigits_Letters_Symbolls(type) != "Letters")
            {
                return "The type name must only has letters";
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
            }else if (CheckGigits_Letters_Symbolls(minute) != "Digits" || (!int.TryParse(minute.Text, out int minuteValue) || minuteValue > 59 || minuteValue <= 0))
            {
                minute.Focus();
                return "The minutes of the class must contain 2 numbers.\n\nThe minute must be between 0 and 59.";
            }
            else if (time.SelectedItem == null)
            {
                return "Please select time.";
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
                return "Invalid Price";
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
    }
}
