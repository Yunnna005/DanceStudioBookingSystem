using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace DanceStudioBookingSystem.Member
{
    class Members
    {
        private int memberID;
        private string firstname;
        private string lastname;
        private string gender;
        private string email;
        private string phone;
        private DateTime dob;
        private string password;

        public Members() 
        { 
            this.memberID = 0;
            this.firstname = "";
            this.lastname = "";
            this.gender = "";
            this.email = "";
            this.phone = "";
            this.dob = DateTime.Now;
            this.password = "";
        }

        //int memberID,string status
        public Members(string firstname, string lastname, string gender, string email, string phone, DateTime dob, string password)
        {
            this.memberID = getNextMemberID();
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.email = email.ToLower();
            this.phone = phone;
            this.dob = dob;
            this.password = password;
        }

        public Members(string firstname, string lastname, string gender, string email, string phone, DateTime dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.email = email.ToLower();
            this.phone = phone;
            this.dob = dob;
        }

        //getters
        public int getMemberID() { return memberID; }
        public string getFirstname() { return firstname;}
        public string getLastname() { return lastname;}
        public string getGender() { return gender;}
        public string getEmail() { return email;}
        public string getPhone() { return phone;}
        public DateTime getDOB() { return dob;}
        public string getPassword() { return password;}

        //setters
        public void setMemberID(int MemberID) { memberID = MemberID; }
        public void setFirstName(string Firstname) {  firstname = Firstname; }
        public void setLastName(string Lastname) {  lastname = Lastname; }
        public void setGender(string Gender) {  gender = Gender; }
        public void setEmail(string Email) { email = Email; }
        public void setPhone(string Phone) { phone = Phone; }  
        public void setDOB(DateTime DOB) { dob = DOB; }
        public void setPassword(string Password) { password = Password; }


        public void addMember()
        {
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Members VALUES (" +
                this.memberID + ",'" +
                this.firstname + "','" +
                this.lastname + "','" +
                this.gender + "','" +
                this.email + "'," +
                this.phone + ",'" +
                this.dob.ToString("dd-MMM-yyyy") + "','" +
                this.password + "')";

            // Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            // Close db connection
            conn.Close();
        }

        public void updateMember(int memberID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "Firstname = '" + this.firstname + "'," +
                "Lastname = '" + this.lastname + "'," +
                "Gender = '" + this.gender + "'," +
                "DOB = '" + this.dob.ToString("dd-MMM-yyyy") + "'," +
                "Email = '" + this.email + "'," +
                "Phone = " + this.phone + " " +
                "WHERE Member_ID = '" + memberID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void UpdateMemberAndPassword(int memberID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "Firstname = '" + this.firstname + "'," +
                "Lastname = '" + this.lastname + "'," +
                "Gender = '" + this.gender + "'," +
                "Email = '" + this.email + "'," +
                "Phone = " + this.phone + "," +
                "DOB = '" + this.dob.ToString("dd-MMM-yyyy") + "'," +
                "Password = '" + this.password + "' " +
                "WHERE Member_ID = '" + memberID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void DeleteMember(int memberID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "Delete From Members WHERE Member_ID = " + memberID + "";    

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            //cmd.Parameters.Add("Member_ID", @memberID);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static int getNextMemberID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(Member_Id) FROM Members";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public void ResetPassword(int memberID, string newPassword){
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "Password = " + newPassword + " " +
                "WHERE Member_ID = " + memberID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    }
}
