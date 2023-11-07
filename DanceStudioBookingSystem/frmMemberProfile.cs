using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    public partial class frmMemberProfile : Form
    {
        public frmMemberProfile()
        {
            InitializeComponent();
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformMenuBook(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformLogOut(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditMemberProfile fEditProfile = new frmEditMemberProfile();
            fEditProfile.Show();
        }


        
    }
}
