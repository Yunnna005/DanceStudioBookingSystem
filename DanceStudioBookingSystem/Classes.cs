﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DanceStudioBookingSystem
{
    class Classes
    {
        private int _classID;
        private string _name;
        private string _typeID;
        private DateTime _date;
        private string _time_hour;
        private string _time_minute;
        private int _instructorID;
        private int _avaliablePlaces;
        private int _capacity;
        private float _price;

        public Classes() 
        { 
            _classID = 0;
            this._name = "";
            this._typeID = "";
            this._date = DateTime.Now;
            this._time_hour = "0";
            this._time_minute = "0";
            this._instructorID = 0;
            this._avaliablePlaces = 0;
            this._capacity = 0;
            this._price = 0;
        }

        public Classes(string name, ComboBox type, DateTime date, string time_hour, string time_minute, ComboBox instructorID, int capacity, float price)
        {
            _classID = getNextClassID();
            _name = name;
            _typeID = getTypeID(type.Text);
            _date = date;
            _time_hour = time_hour;
            _time_minute = time_minute;
            _instructorID = getInstructorID(instructorID.Text);
            _avaliablePlaces = capacity;
            _capacity = capacity;
            _price = price;
        }

        //getters
        public string getName() { return _name; }
        public string getType() { return _typeID; }
        public DateTime getDate() { return _date; }
        public string getTimeHour() { return _time_hour; }
        public string getTimeMinute() { return _time_minute; }
        public int getInstructor() { return _instructorID; }
        public int getAvaliablePlaces() { return _avaliablePlaces; }
        public int getCapacity() { return _capacity; }
        public float getPrice() { return _price; }

        //setters
        public void setName(string name) { _name = name; }
        public void setType(string type) { _typeID = type; }
        public void setDate(DateTime date) { _date = date; }
        public void setTimeHour(string time_hour) {  _time_hour = time_hour; }
        public void setTimeMinute(string time_minute) {  _time_minute = time_minute; }
        public void setInstructor(int instructor) {  _instructorID = instructor; }
        public void setAvaliablePlaces(int avaliablePlaces) {  _avaliablePlaces = avaliablePlaces;}
        public void setCapacity(int capacity) {  _capacity = capacity; }
        public void setPrice(float price) {  _price = price; }


        public void addClass()
        {
            string timeCode = _time_hour.ToString() + ":" + _time_minute;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Classes VALUES (" +
                _classID + ",'" +
                _name + "','" +
                _date.ToString("dd-MMM-yyyy") + "','" +
                timeCode + "', " +
                _avaliablePlaces + " , " +
                _capacity + "," +
                _price + "," +
                _instructorID + ",'" +
                _typeID +  "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void modifyClass(int classID)
        {
            string timeCode = _time_hour.ToString()+":"+_time_minute;
            OracleConnection conn = new OracleConnection( DBConnect.oraDB);

            String sqlQuery = "UPDATE Classes SET " +
                "Name = '" + _name + "'," +
                "Type_ID = '" + _typeID + "'," +
                "DateCode = '" + _date.ToString("dd-MMM-yyyy") + "'," +
                "TimeCode = '" + timeCode + "'," +
                "Instructor_ID = " + _instructorID + "," +
                "Capacity = " + _capacity + "," +
                "Price = " + _price + " " + 
                "WHERE Class_ID = '" + classID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void cancelClass(int classID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "Delete FROM Classes WHERE Class_ID = " + classID + "";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateAvaliablePlaces_BookProcess(int classID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Classes SET AvaliablePlaces = AvaliablePlaces-1 WHERE Class_ID = " + classID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateAvaliablePlaces_CancelProcess(int classID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Classes SET AvaliablePlaces = AvaliablePlaces+1 WHERE Class_ID = " + classID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update_Qty_of_class_type_Schedule(string typeID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                String sqlQuery = "UPDATE Class_Types SET Qty_of_classes = Qty_of_classes + 1 WHERE Type_ID = :Type_ID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Type_ID", OracleDbType.Varchar2).Value = typeID;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update_Qty_of_class_type_Cancel(string typeID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                String sqlQuery = "UPDATE Class_Types SET Qty_of_classes = Qty_of_classes - 1 WHERE Type_ID = :Type_ID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Type_ID", OracleDbType.Varchar2).Value = typeID;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int getNextClassID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(Class_Id) FROM Classes";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

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
            conn.Close();

            return nextId;
        }

        public string getTypeID(string type)
        {
            string typeID;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT Type_ID FROM Class_Types WHERE Type = :type";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Type", OracleDbType.Varchar2).Value = type;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return typeID = (string)reader["Type_ID"];

                        }
                    }
                    return "Not Found";
                }
            }
        }
        public string getTypeName(string typeId)
        {
            string typeName;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT * FROM Class_Types WHERE Type = :typeId";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Type", OracleDbType.Varchar2).Value = typeId;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return typeName = (string)reader["Type"];

                        }
                    }
                    return "Not Found";
                }
            }
        }

        public int getInstructorID(string instructor)
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
        public string getInstructorName(int instructorID)
        {
            string instructorName;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string query = "SELECT FullName FROM Instructors WHERE Instructor_ID = :instructorID";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Instructor_ID", OracleDbType.Varchar2).Value = instructorID;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return instructorName = (string)reader["FullName"];

                        }
                    }
                    return "Not found";
                }
            }
        }

        public bool CheckIfClassBooked(int classID)
        {
            int capacity;
            int availablePlaces;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();
                string query = "SELECT Capacity, AvaliablePlaces FROM Classes WHERE Class_ID = :Class_ID";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    command.Parameters.Add("Class_ID", classID);
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            availablePlaces = reader.GetInt32(reader.GetOrdinal("AvaliablePlaces"));
                            capacity = reader.GetInt32(reader.GetOrdinal("Capacity"));

                            if (capacity > 0 && availablePlaces < capacity)
                            {
                                return true; // The class is already booked by someone
                            }

                            return false;
                        }
                    }
                }
            }

            return false;
        }
    }
}
