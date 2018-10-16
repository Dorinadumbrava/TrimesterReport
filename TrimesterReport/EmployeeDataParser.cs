using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class EmployeeDataParser
    {
        private readonly int nrOfarguments = 5;
        public void ParseData(string employeeInput)
        {
            string[] employeeData = employeeInput.Split(' ');
            if (employeeData.Length == nrOfarguments)
            {

            }
        }
    }
}
