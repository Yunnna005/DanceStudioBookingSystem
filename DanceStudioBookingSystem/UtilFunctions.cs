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

        //Forms: frmResetPassword
        public static void PerformBackToLogIn(Form activeForm)
        {
            activeForm.Close();
            frmLogIn fLogIn = new frmLogIn();
            fLogIn.Show();
        }

        //Forms: frmBookClass
        public static void PerformMenuProfile(Form activeForm)
        {
            activeForm.Close();
            frmMemberProfile fMemberProfile = new frmMemberProfile();
            fMemberProfile.Show();

        }

        //Forms: frmMemberProfile
        public static void PerformMenuBook(Form activeForm)
        {
            activeForm.Close();
            frmBookClass fBookClass = new frmBookClass();
            fBookClass.Show();
        }

        //Forms: frmMainMenuAdmin, frmMemberProfile
        public static void PerformLogOut(Form activeForm)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You loged out. Go to Log in.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                activeForm.Close();
                frmLogIn fLogIn = new frmLogIn();
                fLogIn.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        //Forms: frmModifyClass,frmCancelClass, frmMainMenuAdmin, frmStatistics
        public static void DisplayScheduleClass(Form activeForm)
        {
            activeForm.Close();
            frmScheduleClass fScheduleClass = new frmScheduleClass();
            fScheduleClass.Show();
        }

        //Forms: frmScheduleClass,frmCancelClass, frmMainMenuAdmin, frmStatistics
        public static void DisplayModifyClass(Form activeForm)
        {
            activeForm.Close();
            frmModifyClass fModifyClass = new frmModifyClass();
            fModifyClass.Show();
        }

        //Forms: frmScheduleClass, frmModifyClass, frmMainMenuAdmin, frmStatistics
        public static void DisplayCancelClass(Form activeForm)
        {
            activeForm.Close();
            frmCancelClass fCancelClass = new frmCancelClass();
            fCancelClass.Show();
        }

        //Forms: frmScheduleClass, frmModifyClass, frmCancelClass, frmMainMenuAdmin
        public static void DisplayStatistics(Form activeForm)
        {
            activeForm.Close();
            frmStatistics fStatistics = new frmStatistics();
            fStatistics.Show();
        }

        //Forms: frmScheduleClass, frmModifyClass, frmCancelClass, frmStatistics
        public static void DisplayMainMenuAdmin(Form activeForm)
        {
            activeForm.Close();
            frmMainMenuAdmin fMainMenuAdmin = new frmMainMenuAdmin();
            fMainMenuAdmin.Show();
        }


        //Forms: frmCreateAccount, frmEditMemberProfile
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



        //Forms: frmMainMenuAdmin, frmScheduleClass
        public static class ClassDataStorage
        {
            public static List<ClassInfo> Classes { get; } = new List<ClassInfo>();
        }

        public class ClassInfo
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Instructor { get; set; }
            public int Capacity { get; set; }
            public decimal Price { get; set; }
        }
    }
}
