using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class EmloyeeLists
    {
        private List<Employee> _employeeList = new List<Employee>();
        public List<Employee> EmployeeList
        {
            get
            {
                return _employeeList;
            }
            set
            {
                _employeeList = value;

            }
        }
        
    }
}
