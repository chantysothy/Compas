using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.CashRegisters
{
    public class Check
    {
        
        public Check(decimal _Total, string _Number, string _Date, string _Time, string OperNumber)
        {
            Total = _Total;
            Number = _Number;
            Date = _Date;
            Time = _Time;
            operNumber = OperNumber;
        }

        private decimal total;
        private string number;
        private string date;
        private string time;
        private string operNumber;

        public decimal Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public DateTime FullDate
        {
            get
            { 
                DateTime onlyTime = Convert.ToDateTime(time);
                return Convert.ToDateTime(date).AddHours(onlyTime.Hour).AddMinutes(onlyTime.Minute).AddSeconds(onlyTime.Second).AddMilliseconds(onlyTime.Millisecond);
            }
            
        }

        public string OperNumber
        {
            get
            {
                return operNumber;
            }
            set
            {
                operNumber = value;
            }
        }
    }
}
