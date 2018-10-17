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
        Report anotherReport = new Report();
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
            int i = 1;
            foreach (var employee in employeeList1.EmployeeList)
            {
                Console.WriteLine("Employee {0}, {2} {3} with ID {1} has a salary of {4} on the date {5}.", i, employee.ID, employee.FirstName, employee.LastName
                    , employee.Salary, employee.Date);
                i++;
            }
        }
        public void generateReport()
        {
            anotherReport.GenerateTrimesterReport(employeeList1.EmployeeList);
        }
    }
}
