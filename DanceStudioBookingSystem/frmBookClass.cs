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
    public partial class frmBookClass : Form
    {
        Form parentForm;
        public frmBookClass(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void frmBookClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
