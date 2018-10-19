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
            var groupByYear = from employee in employeeList
                              group employee by employee.Date.Year into employeeByYear
                              orderby employeeByYear.Key
                              select new
                              {
                                  year = employeeByYear.Key,
                                  trimesters = from yearEmployee in employeeByYear
                                  group yearEmployee by Converter.GroupByTrimester(yearEmployee.Date) into trimesterGroups
                                  orderby trimesterGroups.Key
                                  select trimesterGroups
                              };


            foreach (var employee in groupByYear)
            {
                Console.WriteLine(employee.year);
                var averageSalary = 0;
                foreach (var empl in employee.trimesters)
                {
                    int count = 0;
                    Console.WriteLine(empl.Key);
                    foreach (var trimesterEmployee in empl)
                    {

                        averageSalary += trimesterEmployee.Salary;
                        count++;
                    }
                    averageSalary = averageSalary / empl.Count();
                    Console.WriteLine("The avg salary is {0}, Here are {1}, {2} salaries", averageSalary, empl.Count(), count);
                }
                
            }
            
        }


    }
}
