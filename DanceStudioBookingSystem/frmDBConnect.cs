using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;

namespace DanceStudioBookingSystem
{
    public partial class frmDBConnect : Form
    {
        Form parent;

        OracleConnection conn = new OracleConnection(DBConnect.oraDB);
        public frmDBConnect(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                lblState.Text = "CLOSED";
                lblState.ForeColor = Color.Black;
                btnMenu.Visible = false;
            }
            else
            {
                conn.Open();
                lblState.Text = "OPEN";
                lblState.ForeColor = Color.Red;
                btnMenu.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmClassesOverview(this));
        }

        private void frmDBConnect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
