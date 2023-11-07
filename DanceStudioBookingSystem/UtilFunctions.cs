using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    class UtilFunctions
    {
        public static void PerformMenuProfile(Form activeForm)
        {
            activeForm.Hide();
            frmMemberProfile fMemberProfile = new frmMemberProfile();
            fMemberProfile.Show();
        }
        public static void PerformMenuBook(Form activeForm)
        {
            activeForm.Hide();
            frmBookClass fBookClass = new frmBookClass();
            fBookClass.Show();
        }
        public static void PerformLogOut(Form activeForm)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You loged out. Go to Log in.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                activeForm.Hide();
                frmLogIn fLogIn = new frmLogIn();
                fLogIn.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
