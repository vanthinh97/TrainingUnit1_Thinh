using System;
using TrainingUnit1.Controllers;

namespace TrainingUnit1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController useControl = new EmployeeController();
            useControl.AddData();

            int choice = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("EMPLOYEE MANAGEMENT");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Show all employees");
                Console.WriteLine("2. Add new employee");
                Console.WriteLine("3. Update employee");
                Console.WriteLine("4. Find employee");
                Console.WriteLine("5. Delete employee");
                Console.WriteLine("6. Show best employees");
                Console.WriteLine("7. Exit");
                Console.WriteLine("--Please select the option--");

                do
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch { }
                } while (true);

                switch (choice)
                {
                    case 1:
                        useControl.ShowAll();
                        break;
                    case 2:
                        useControl.AddEmployee();
                        break;
                    case 3:
                        useControl.EditEmployee();
                        break;
                    case 4:
                        useControl.FindEmployee();
                        break;
                    case 5:
                        useControl.removeEmployee();
                        break;
                    case 6:
                        useControl.ShowBestEmployees();
                        break;

                }
            } while (choice != 7);
        }
    }
}
