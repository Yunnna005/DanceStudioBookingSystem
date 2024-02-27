using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceStudioBookingSystem
{
    class Bookings
    {
        private int _bookingID;
        private string _cardHolder;
        private long _cardNumber;
        private DateTime _paymentDate;
        private float _price;
        private int _memberID;
        private int _classID;


        public Bookings()
        {
            _bookingID = 0;
            _cardHolder = "";
            _cardNumber = 0;
            _paymentDate = DateTime.Now;
            _price = 0;
            _memberID = 0;
            _classID = 0;
        }

        public Bookings(string cardName, long cardNumber, int memberID, int classID) 
        {
            _bookingID = getNextBookingsID();
            _cardHolder = cardName;
            _cardNumber = cardNumber;
            _paymentDate = DateTime.Now;
            _price = getPrice(classID);
            _memberID = memberID;
            _classID = classID;

        }

        //getters
        public string getCardHolder() { return _cardHolder; }
        public long getCardNumber() { return _cardNumber; }
        public DateTime getPaymentDate() { return _paymentDate; }
        public float getPrice() { return _price; }

        //setters
        public void setCardHolder(string cardHolder) { _cardHolder = cardHolder; }
        public void setCardNUmber(long cardNumber) { _cardNumber = cardNumber; }
        public void setPaymentDate(DateTime paymentDate) { _paymentDate = paymentDate; }
        public void setPrice(float price) { _price = price; }


        public void addBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //check database variables
            String sqlQuery = "INSERT INTO Bookings VALUES (" +
                _bookingID + ",'" +
                _cardHolder + "'," +
                _cardNumber + ",'" +
                _paymentDate.ToString("dd-MMM-yyyy") + "'," +
                _price + "," +
                _memberID + "," +
                _classID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void cancelBooking(int bookingID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "Delete FROM Bookings WHERE Booking_ID = " + bookingID + "";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private float getPrice(int classID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT Price FROM Classes WHERE Class_ID = :classID";

                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("classID", classID));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (float)reader["Price"];
                        }
                    }
                }
            }

            return 0;
        }

        public static int getNextBookingsID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(Booking_Id) FROM Bookings";

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
