using System;
using System.Collections.Generic;
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
    }
}
