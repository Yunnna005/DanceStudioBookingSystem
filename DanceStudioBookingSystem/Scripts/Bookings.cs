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
        private int bookingID;
        private string cardHolder;
        private string cardNumber;
        private DateTime paymentDate;
        private int price;
        private int memberID;
        private int classID;


        public Bookings()
        {
            this.bookingID = 0;
            this.cardHolder = "";
            this.cardNumber = "";
            this.paymentDate = DateTime.Now;
            this.price = 0;
            this.memberID = 0;
            this.classID = 0;
        }

        public Bookings(string cardName, string cardNumber, int memberID, int classID)
        {
            this.bookingID = getNextBookingsID();
            this.cardHolder = cardName;
            this.cardNumber = cardNumber;
            this.paymentDate = DateTime.Now;
            this.price = getPrice(classID);
            this.memberID = memberID;
            this.classID = classID;
        }

        //getters
        public string getCardHolder() { return cardHolder; }
        public string getCardNumber() { return cardNumber; }
        public DateTime getPaymentDate() { return paymentDate; }
        public int getPrice() { return price; }

        //setters
        public void setCardHolder(string cardHolder) { this.cardHolder = cardHolder; }
        public void setCardNUmber(string cardNumber) { this.cardNumber = cardNumber; }
        public void setPaymentDate(DateTime paymentDate) { this.paymentDate = paymentDate; }
        public void setPrice(int price) { this.price = price; }


        public void addBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //check database variables
            String sqlQuery = "INSERT INTO Bookings VALUES (" +
                bookingID + ",'" +
                cardHolder + "','" +
                cardNumber + "','" +
                paymentDate.ToString("dd-MMM-yyyy") + "'," +
                price + "," +
                memberID + "," +
                classID + ")";

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

        private int getPrice(int classID)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    string sqlQuery = "SELECT Price FROM Classes WHERE Class_ID = :classID";

                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add("classID", OracleDbType.Int32).Value = classID;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(reader.GetOrdinal("Price"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching price: " + ex.Message);
                // Handle the exception or log it as needed
            }

            return 0; // Default value if the price cannot be retrieved
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

