using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class Report
    {
        public void GenerateTrimesterReport(List<Employee> employeeList)
        {

            employeeList.GroupBy(g => g.Date.Year).OrderBy(key => key);
            employeeList.GroupBy(g => Converter.GroupByTrimester(g.Date), k => k.Salary);
            Console.WriteLine("ordered");
            //foreach (var employee in employeeList)
            //{
            //    Console.WriteLine("User:{1} {2} has a salry of {3} on date {4}.", employee.ID, employee.FirstName, employee.LastName, employee.Salary, employee.Date);
            //}
        }
        
    }
}
