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
        private string _name;
        private string _type;
        private DateTime _date;
        private int _time_hour;
        private int _time_minute;
        private string _instructor;
        private int _capacity;
        private float _price;

        public Classes() 
        { 
            this._name = "";
            this._type = "";
            this._date = DateTime.Now;
            this._time_hour = 0;
            this._time_minute = 0;
            this._instructor = "";
            this._capacity = 0;
            this._price = 0;
        }

        public Classes(string name, string type, DateTime date, int time_hour, int time_minute, string instructor, int capasity, float price)
        {
            _name = name;
            _type = type;
            _date = date;
            _time_hour = time_hour;
            _time_minute = time_minute;
            _instructor = instructor;
            _capacity = capasity;
            _price = price;
        }

        //getters
        public string getName() { return _name; }
        public string getType() { return _type; }
        public DateTime getDate() { return _date; }
        public int getTimeHour() { return _time_hour; }
        public int getTimeMinute() { return _time_minute; }
        public string getInstructor() { return _instructor; }
        public int getCapacity() { return _capacity; }
        public float getPrice() { return _price; }

        //setters
        public void setName(string name) { _name = name; }
        public void setType(string type) { _type = type; }
        public void setDate(DateTime date) { _date = date; }
        public void setTimeHour(int time_hour) {  _time_hour = time_hour; }
        public void setTimeMinute(int time_minute) {  _time_minute = time_minute; }
        public void setInstructor(string instructor) {  _instructor = instructor; }
        public void setCapacity(int capacity) {  _capacity = capacity; }
        public void setPrice(float price) {  _price = price; }
    }
}
