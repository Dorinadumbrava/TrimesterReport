using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _salary;
        private DateTime _date;
        private List<int> idList = new List<int>();

        public int ID
        {
            get
            { return _id; }
            set
            {
                if (idList.Contains(ID))
                {
                    Console.WriteLine("This ID already exists");
                }
                else
                {
                    _id = value;
                    idList.Add(value);
                }
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public Employee (string[] employeeDataArray)
        {
            
            int temporaryUserInt;
            if (Int32.TryParse(employeeDataArray[0], out temporaryUserInt))
            {
                ID = temporaryUserInt;
                //Console.WriteLine(temporaryUserInt);
            }
            FirstName = employeeDataArray[1];
            LastName = employeeDataArray[2];
            //Console.WriteLine(FirstName);
            //Console.WriteLine(LastName);
            if (Int32.TryParse(employeeDataArray[3], out temporaryUserInt))
            {
                Salary = temporaryUserInt;
                //Console.WriteLine(temporaryUserInt);
            }
            DateTime userDate;
            if (DateTime.TryParseExact(employeeDataArray[4], "dd/MM/yyyy", CultureInfo.InvariantCulture,
                       DateTimeStyles.None, out userDate))
            {
                Date = userDate;
                //Console.WriteLine(ID + " " + userDate);
            }
            //Console.WriteLine("User: {0}, {1} {2} has a salry of {3} on date {4}.", ID, FirstName, LastName, Salary, Date);
        }
    }
}
