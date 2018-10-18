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
            var groupByYear =
                from employee in employeeList
                group employee by employee.Date.Year into employeeByYear
                orderby employeeByYear.Key
                select (from employee in employeeByYear
                        group employee by Converter.GroupByTrimester(employee.Date) into employeeByTrimester
                        select employeeByTrimester);
            
            foreach (var year in groupByYear)
            {
                Console.WriteLine(year);
                var averageSalary = 0;
                foreach (var trimester in year)
                {
                    Console.WriteLine(trimester);
                    foreach (var employee in trimester)
                    {
                        averageSalary += employee.Salary;
                    }
                    averageSalary = averageSalary / trimester.Count();
                    Console.WriteLine("The avg salary is " +averageSalary);
                }

            }
        }
        
    }
}
