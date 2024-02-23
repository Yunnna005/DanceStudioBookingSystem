using DanceStudioBookingSystem.Member;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DanceStudioBookingSystem.UtilFunctions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DanceStudioBookingSystem
{
    public partial class frmScheduleClass : Form
    {
        Form parent;
        public frmScheduleClass()
        {
            InitializeComponent();
            InsertDataToComboBox(cboType);
            InsertDataToComboBox(cboInstructor);

        }
        public frmScheduleClass(Form parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            InsertDataToComboBox(cboType);
            InsertDataToComboBox(cboInstructor);
        }

        private void mnutScheduleClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on this page.", "Schedule Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnutModifyClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmModifyClass(this));
        }

        private void mnutCancelClass_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmCancelClass(this));
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmStatistics(this));
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            traverseForm(this, new frmClassesOverview(this));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidClassDetails(txtName, cboType, txtHour, txtMinute, cboInstructor, txtCapacity, txtPrice).Equals("valid"))
            {

                int capacity = int.Parse(txtCapacity.Text);
                float price = float.Parse(txtPrice.Text);

                Classes aClass = new Classes(txtName.Text, getTypeID(cboType.Text), dtpDate.Value, txtHour.Text, txtMinute.Text, getInstructorID(cboInstructor.Text), capacity, price);
                aClass.addClass();

                MessageBox.Show("The class was created", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                traverseForm(this, new frmClassesOverview(this));
            }
            else
            {
                MessageBox.Show(ValidClassDetails(txtName, cboType, txtHour, txtMinute, cboInstructor, txtCapacity, txtPrice), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string getTypeID(string type) // change
        {
            string typeID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Class_Types WHERE Type = :type";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("FullName", OracleDbType.Varchar2).Value = type;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return typeID = (string)reader["Instructor_ID"];

                        }
                    }
                    return "Not Found";
                }
            }
        }

        private int getInstructorID(string instructor) // change
        {
            int instructorID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Instructors WHERE FullName = :instructor";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("FullName", OracleDbType.Varchar2).Value = instructor;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return instructorID = (int)reader["Instructor_ID"];

                        }
                    }
                    return 0;
                }
            }
        }

        private void frmScheduleClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FillTypes()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();
                string query = "SELECT Type FROM Class_Types";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items in ComboBox
                        cboType.Items.Clear();

                        // Populate ComboBox with data
                        while (reader.Read())
                        {
                            string itemName = reader.GetString(0); // Assuming the column is of string type
                            cboType.Items.Add(itemName);
                        }
                    }
                }
            }
        }
    }
}
