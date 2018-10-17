using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a working method");
            Console.WriteLine("Write 'F' to read from file, 'I' to pass arguments and pres Enter to to read from console");
            string userChoice = Console.ReadLine().ToUpper();
            Report report1 = new Report();
            EmployeeDataParser input1 = new EmployeeDataParser();
            switch (userChoice)
            {
                case "F":
                    {
                        Console.WriteLine("Give a path to your file");
                        //validate the input
                        string connectToUserInput = Console.ReadLine();
                        string allUserInputs = System.IO.File.ReadAllText(connectToUserInput);
                        string[] fileUserInputs = allUserInputs.Split(';');
                        if (fileUserInputs.Length > 0)
                        {
                            foreach (string input in fileUserInputs)
                            {
                                input1.ParseData(input);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no arguments inserted");
                        }
                        //input1.showData();
                        //EmployeeData.CreateUser();
                    }
                    break;
                case "I":
                    {
                        Console.WriteLine("The data will be taken from arguments");
                        if (args.Length > 0)
                        {
                            foreach (string input in args)
                            {
                                string[] argsUserInputs = input.Split(';');
                                if (argsUserInputs.Length > 0)
                                {
                                    foreach (string cmdInput in argsUserInputs)
                                    {
                                        input1.ParseData(cmdInput);
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no arguments inserted");
                        }
                        //EmployeeData.CreateUser();
                        //GetData.ShowUserInputs();
                    }
                    break;
                case "":
                    {
                        Console.WriteLine("Write your user data: ");
                        Console.WriteLine("Once you finsh your inputs, press Enter.");
                        string consoleInput = " ";
                        while (consoleInput.Length > 0)
                        {
                            consoleInput = Console.ReadLine();
                            //GetData.ReadAndSplit(consoleInput);
                        }
                        //EmployeeData.CreateUser();
                        //GetData.ShowUserInputs();

                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Your users:");
            input1.generateReport();
            input1.showData();
            Console.ReadLine();
        }
    }
}
