using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this._capacity = 0;
            this._price = 0;
        }

        public Classes(string name, string type, DateTime date, string time_hour, string time_minute, int instructor, int capacity, float price)
        {
            _classID = getNextClassID();
            _name = name;
            _typeID = type;
            _date = date;
            _time_hour = time_hour;
            _time_minute = time_minute;
            _instructorID = instructor;
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
        public int getCapacity() { return _capacity; }
        public float getPrice() { return _price; }

        //setters
        public void setName(string name) { _name = name; }
        public void setType(string type) { _typeID = type; }
        public void setDate(DateTime date) { _date = date; }
        public void setTimeHour(string time_hour) {  _time_hour = time_hour; }
        public void setTimeMinute(string time_minute) {  _time_minute = time_minute; }
        public void setInstructor(int instructor) {  _instructorID = instructor; }
        public void setCapacity(int capacity) {  _capacity = capacity; }
        public void setPrice(float price) {  _price = price; }


        public void addClass()
        {
            string timeCode = _time_hour.ToString() + ":" + _time_minute;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Classes VALUES ('" +
                _classID + ",'" +
                _name + "','" +
                _typeID + "','" +
                _date.ToString("dd-MMM-yyyy") + "','" +
                timeCode + " ', '" +
                _instructorID + "'," +
                _capacity + "," +
                _price + ")";

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
                "Price = " + _price + ")";

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
    }
}
