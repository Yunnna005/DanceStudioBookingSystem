using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

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
        private string _dob;
        private string _password;
        private string _status;

        public Members() 
        { 
            this._memberID = 0;
            this._firstname = "";
            this._lastname = "";
            this._gender = "";
            this._email = "";
            this._phone = "";
            this._dob = "";
            this._password = "";
            this._status = "";
        }

        public Members(int memberID, string firstname, string lastname, string gender, string email, string phone, string dob, string password, string status)
        {
            _memberID = memberID;
            _firstname = firstname;
            _lastname = lastname;
            _gender = gender;
            _email = email;
            _phone = phone;
            _dob = dob;
            _password = password;
            _status = status;
        }

        //getters
        public int getMemberID() { return _memberID; }
        public string getFirstname() { return _firstname;}
        public string getLastname() { return _lastname;}
        public string getGender() { return _gender;}
        public string getEmail() { return _email;}
        public string getPhone() { return _phone;}
        public string getDOB() { return _dob;}
        public string getPassword() { return _password;}
        public string getStatus() { return _status;}

        //setters
        public void setMemberID(int MemberID) { _memberID = MemberID; }
        public void setFirstName(string Firstname) {  _firstname = Firstname; }
        public void setLastName(string Lastname) {  _lastname = Lastname; }
        public void setGender(string Gender) {  _gender = Gender; }
        public void setEmail(string Email) { _email = Email; }
        public void setPhone(string Phone) { _phone = Phone; }  
        public void setDOB(string DOB) { _dob = DOB; }
        public void setPassword(string Password) { _password = Password; }
        public void setStatus(string Status) { _status = Status; }


        public void addMember()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Members Values (" +
                this._memberID + ",'" +
                this._firstname + ",'" +
                this._lastname + ",'" +
                this._gender + ",'" +
                this._email + ",'" +
                this._phone + ",'" +
                this._dob + ",'" +
                this._password + ",'" +
                this._status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    }
}
