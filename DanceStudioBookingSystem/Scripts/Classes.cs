using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    class Classes
    {
        private int classID;
        private string name;
        private string typeID;
        private DateTime date;
        private string time_hour;
        private string time_minute;
        private int instructorID;
        private int avaliablePlaces;
        private int capacity;
        private float price;

        public Classes() 
        { 
            this.classID = 0;
            this.name = "";
            this.typeID = "";
            this.date = DateTime.Now;
            this.time_hour = "0";
            this.time_minute = "0";
            this.instructorID = 0;
            this.avaliablePlaces = 0;
            this.capacity = 0;
            this.price = 0;
        }

        public Classes(string name, ComboBox type, DateTime date, string time_hour, string time_minute, ComboBox instructorID, int capacity, float price)
        {
            this.classID = getNextClassID();
            this.name = name;
            this.typeID = getTypeID(type.Text);
            this.date = date;
            this.time_hour = time_hour;
            this.time_minute = time_minute;
            this.instructorID = getInstructorID(instructorID.Text);
            this.avaliablePlaces = capacity;
            this.capacity = capacity;
            this.price = price;
        }

        //getters
        public string getName() { return name; }
        public string getType() { return typeID; }
        public DateTime getDate() { return date; }
        public string getTimeHour() { return time_hour; }
        public string getTimeMinute() { return time_minute; }
        public int getInstructor() { return instructorID; }
        public int getAvaliablePlaces() { return avaliablePlaces; }
        public int getCapacity() { return capacity; }
        public float getPrice() { return price; }

        //setters
        public void setName(string name) { this.name = name; }
        public void setType(string type) { this.typeID = type; }
        public void setDate(DateTime date) { this.date = date; }
        public void setTimeHour(string time_hour) {  this.time_hour = time_hour; }
        public void setTimeMinute(string time_minute) {  this.time_minute = time_minute; }
        public void setInstructor(int instructor) {  this.instructorID = instructor; }
        public void setAvaliablePlaces(int avaliablePlaces) {  this.avaliablePlaces = avaliablePlaces;}
        public void setCapacity(int capacity) {  this.capacity = capacity; }
        public void setPrice(float price) {  this.price = price; }


        public void addClass()
        {
            string timeCode = time_hour.ToString() + ":" + time_minute;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Classes VALUES (" +
                classID + ",'" +
                name + "','" +
                date.ToString("dd-MMM-yyyy") + "','" +
                timeCode + "', " +
                avaliablePlaces + "," +
                capacity + "," +
                price + "," +
                instructorID + ",'" +
                typeID +  "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void modifyClass(int classID)
        {
            string timeCode = time_hour.ToString()+":"+time_minute;
            OracleConnection conn = new OracleConnection( DBConnect.oraDB);

            String sqlQuery = "UPDATE Classes SET " +
                "Name = '" + name + "'," +
                "Type_ID = '" + typeID + "'," +
                "DateCode = '" + date.ToString("dd-MMM-yyyy") + "'," +
                "TimeCode = '" + timeCode + "'," +
                "Instructor_ID = " + instructorID + "," +
                "Capacity = " + capacity + "," +
                "Price = " + price + " " + 
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

                string sqlQuery = "SELECT Type_ID FROM Class_Types WHERE Type = :type";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Type", OracleDbType.Varchar2).Value = type;

                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return typeID = (string)rd["Type_ID"];

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

                string sqlQuery = "SELECT * FROM Class_Types WHERE Type = :typeId";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Type", OracleDbType.Varchar2).Value = typeId;

                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return typeName = (string)rd["Type"];

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

                string sqlQuery = "SELECT * FROM Instructors WHERE FullName = :instructor";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("FullName", OracleDbType.Varchar2).Value = instructor;

                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return instructorID = (int)rd["Instructor_ID"];
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

                string sqlQuery = "SELECT FullName FROM Instructors WHERE Instructor_ID = :instructorID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Instructor_ID", OracleDbType.Varchar2).Value = instructorID;

                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return instructorName = (string)rd["FullName"];

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
                string sqlQuery = "SELECT Capacity, AvaliablePlaces FROM Classes WHERE Class_ID = :Class_ID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Class_ID", classID);
                    using (OracleDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            availablePlaces = rd.GetInt32(rd.GetOrdinal("AvaliablePlaces"));
                            capacity = rd.GetInt32(rd.GetOrdinal("Capacity"));

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
