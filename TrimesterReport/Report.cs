using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class Report
    { 
        
        public List<string> GenerateTrimesterReport(List<Employee> employeeList)
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
            
            List<string> trimesterReport = new List<string>();
            
            foreach (var years in groupByYear)
            {
                var averageSalary = 0;
                trimesterReport.Add(years.year.ToString());
                foreach (var trimester in years.trimesters)
                {
                    int count = 0;
                    //var averageSalary = trimester.Average(trimester.)
                    foreach (var employee in trimester)
                    {
                        averageSalary += employee.Salary;
                        count++;
                    }
                    averageSalary = averageSalary / trimester.Count();
                    
                    trimesterReport.Add("Trimester "+ trimester.Key.ToString()+": "+ averageSalary.ToString());
                }
            }
            return trimesterReport;
        }

            


    }
}
