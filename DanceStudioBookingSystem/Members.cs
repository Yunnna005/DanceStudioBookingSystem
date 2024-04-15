using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace DanceStudioBookingSystem.Member
{
    class Members
    {
        private int _memberID;
        private string _firstname;
        private string _lastname;
        private string _gender;
        private string _email;
        private string _phone;
        private DateTime _dob;
        private string _password;

        public Members() 
        { 
            this._memberID = 0;
            this._firstname = "";
            this._lastname = "";
            this._gender = "";
            this._email = "";
            this._phone = "";
            this._dob = DateTime.Now;
            this._password = "";
        }

        //int memberID,string status
        public Members(string firstname, string lastname, string gender, string email, string phone, DateTime dob, string password)
        {
            _memberID = getNextMemberID();
            _firstname = firstname;
            _lastname = lastname;
            _gender = gender;
            _email = email.ToLower();
            _phone = phone;
            _dob = dob;
            _password = password;
        }

        public Members(string firstname, string lastname, string gender, string email, string phone, DateTime dob)
        {
            _firstname = firstname;
            _lastname = lastname;
            _gender = gender;
            _email = email.ToLower();
            _phone = phone;
            _dob = dob;
        }

        //getters
        public int getMemberID() { return _memberID; }
        public string getFirstname() { return _firstname;}
        public string getLastname() { return _lastname;}
        public string getGender() { return _gender;}
        public string getEmail() { return _email;}
        public string getPhone() { return _phone;}
        public DateTime getDOB() { return _dob;}
        public string getPassword() { return _password;}

        //setters
        public void setMemberID(int MemberID) { _memberID = MemberID; }
        public void setFirstName(string Firstname) {  _firstname = Firstname; }
        public void setLastName(string Lastname) {  _lastname = Lastname; }
        public void setGender(string Gender) {  _gender = Gender; }
        public void setEmail(string Email) { _email = Email; }
        public void setPhone(string Phone) { _phone = Phone; }  
        public void setDOB(DateTime DOB) { _dob = DOB; }
        public void setPassword(string Password) { _password = Password; }


        public void addMember()
        {
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Members VALUES (" +
                this._memberID + ",'" +
                this._firstname + "','" +
                this._lastname + "','" +
                this._gender + "','" +
                this._email + "'," +
                this._phone + ",'" +
                this._dob.ToString("dd-MMM-yyyy") + "','" +
                this._password + "')";

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
                "Firstname = '" + this._firstname + "'," +
                "Lastname = '" + this._lastname + "'," +
                "Gender = '" + this._gender + "'," +
                "DOB = '" + this._dob.ToString("dd-MMM-yyyy") + "'," +
                "Email = '" + this._email + "'," +
                "Phone = " + this._phone + " " +
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
                "Firstname = '" + this._firstname + "'," +
                "Lastname = '" + this._lastname + "'," +
                "Gender = '" + this._gender + "'," +
                "Email = '" + this._email + "'," +
                "Phone = " + this._phone + "," +
                "DOB = '" + this._dob.ToString("dd-MMM-yyyy") + "'," +
                "Password = '" + this._password + "' " +
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
