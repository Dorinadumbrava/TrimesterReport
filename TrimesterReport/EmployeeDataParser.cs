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
        EmloyeeLists employeeList1 = new EmloyeeLists();
        public void ParseData(string employeeInput)
        {
            employeeInput = employeeInput.TrimEnd();
            string[] employeeData = employeeInput.Split(' ');
            Console.WriteLine(employeeData.Length);
            
            if (employeeData.Length == nrOfarguments)
            {
                employeeList1.EmployeeList.Add(new Employee(employeeData));
            }

        }
        public void showData()
        {
            foreach (var employee in employeeList1.EmployeeList)
            {
                Console.WriteLine(employee.ID+" " + employee.FirstName+" "+employee.LastName+" "+"verify");
            }
        }
    }
}
