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
        static EventHandler giveResults;
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a working method");
            Console.WriteLine("Write 'F' to read from file, 'I' to pass arguments and pres Enter to to read from console");
            string userChoice = args[0].ToUpper();
            EmployeeDataParser input1 = new EmployeeDataParser();
            switch (userChoice)
            {
                case "F":
                    {
                        string connectToUserInput = args[1];
                        string allUserInputs="";
                        try
                        {
                            allUserInputs = System.IO.File.ReadAllText(connectToUserInput);
                        }
                        catch  (FileNotFoundException ex)
                        {
                            Console.WriteLine("There is no input file at this location: {0} .",connectToUserInput, ex);
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
            Printer print1 = new Printer();
            
            //print1.runEvent()
            string path = args[args.Count()];
            print1.FilePrint(input1.generateReport(), path);
            print1.ShowConsole(input1.generateReport());
            Console.ReadLine();
        }
    }
}
