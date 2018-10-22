using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    internal class Printer : IShow, IPrint
    {
        public string GeneratePath (string fileAdress, string fileName)
        {
            string path = "";
            if (fileAdress != null)
            {
                if (fileName != null)
                {
                    path = fileAdress + '/' + fileName;
                }
                else
                    Console.WriteLine("No file Name added");
            }
            else
                Console.WriteLine("No file address added");
            return path;
        }
        public void FilePrint(List<string> report, string path)
        {
            TextWriter saveReport;

            if (path != null)
            {
                if (!File.Exists(path))
                {
                    try
                    {
                        File.Create(path).Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There is a wrong address specified {0}", ex);
                    }
                    
                    saveReport = new StreamWriter(path);
                    foreach (var line in report)
                    {
                        saveReport.WriteLine(line);
                    }
                    saveReport.Close();
                }
                else if (File.Exists(path))
                {
                    saveReport = new StreamWriter(path);
                    foreach (var line in report)
                    {
                        saveReport.WriteLine(line);
                    }
                    saveReport.Close();
                }
            }
            else
                Console.WriteLine("There is no path speciffied");
        }
        

        public void ShowConsole(List<string> report)
        {
            foreach (var row in report)
            {
                Console.WriteLine(row);
            }
        }
    }
}

