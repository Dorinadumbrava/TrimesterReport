using System;
using System.Collections.Generic;
using System.IO;
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
            EmployeeDataParser input1 = new EmployeeDataParser();
            switch (userChoice)
            {
                case "F":
                    {
                        Console.WriteLine("Give a path to your file");
                        //validate the input
                        string connectToUserInput = Console.ReadLine();
                        string allUserInputs="";
                        try
                        {
                            allUserInputs = System.IO.File.ReadAllText(connectToUserInput);
                        }
                        catch  (FileNotFoundException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
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
                        }

                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Your users:");
            Printer print1 = new Printer();
            Console.WriteLine("Give an addres to store your file");
            string fileAddress = Console.ReadLine();
            Console.WriteLine("Give a name for yourFile");
            string fileName = Console.ReadLine();
            var path = print1.GeneratePath(fileAddress, fileName);
            print1.FilePrint(input1.generateReport(), path);
            print1.ShowConsole(input1.generateReport());
            //input1.showData();
            Console.ReadLine();
        }
    }
}
