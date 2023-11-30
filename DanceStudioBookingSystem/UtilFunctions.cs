using System;
using System.Collections.Generic;
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
    }
}
