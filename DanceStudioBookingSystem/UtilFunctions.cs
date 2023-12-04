using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    class UtilFunctions
    {
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


        public static string ValidatonMemberDetails(string firstname, string secondname, string email, string phone, bool genderMale, bool genderFemale, bool genderOther)
        {
            string gender;
            if (secondname == null || firstname == null)
            {
                if (CheckGigits(firstname) == false)
                {
                    return "The Firstname must not contain numbers";
                }
                if (CheckGigits(secondname) == false)
                {
                    return "The Secondname must not contain numbers";
                }

                return "Please enter valid Full Name.";
            }
            else if (email == null || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return "Please enter valid email address";
            }
            else if (phone == null || phone.Length < 9 || !phone.StartsWith("+"))
            {
                return "Please enter valid phone number that starts from +";
            }
            else
            {
                
                if (genderMale)
                {
                    gender = "Male";
                    return gender;
                }
                else if (genderFemale)
                {
                    gender = "Female";
                    return gender;
                }
                else
                {
                    gender = "Other";
                    return gender;
                } 
            }  
        }
        public static bool CheckGigits(string text)
        {
            if (text != null)
            {
                foreach (char c in text)
                {
                    if (c >= '1' && c <= '9')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void InsertDataToComboBox(ComboBox comboBox)
        {
            if (comboBox.Name == "cboType")
            {
                string[] types = { "All","K-pop","Latin","Ballet","Hip-Hop"};
                comboBox.Items.AddRange(types);
            }else if(comboBox.Name == "cboTime")
            {
                string[] time = { "10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30","14:00","14:30","15:00","15:30","16:00","16:30","17:00",
                    "17:30","18:00","18:30"};
                comboBox.Items.AddRange(time);
            }else if (comboBox.Name == "cboInstructor")
            {
                string[] instructors = {"Hyun-Woo Park","Isabella Martinez","Jasmine Williams","Ji-Min Lee","Malik Johnson","Olivia Smith",
                    "Rafael Lopez","Soo-Jin Kim","Xavier Ortiz"};
                comboBox.Items.AddRange(instructors);
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

        public static bool IsValidPriceFormat(string price)
        {
            string format = @"^\d{2}\.\d{2}$"; //Format 00.00
            if (Regex.IsMatch(price, format))
            {
                return true;
            }
            return false;
        }
    }
}
