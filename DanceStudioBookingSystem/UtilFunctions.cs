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


        public static string ValidatonMemberDetails(string username, string email, string phone, bool genderMale, bool genderFemale, bool genderOther)
        {
            string gender;
            if (username == null || username.Length < 8 || char.IsDigit(username[0]))
            {
                return "Please enter the username: \n\n1. More than 8 characters\n2. Does not start from number\n3. Does not start from symbol";
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
    }
}
