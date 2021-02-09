using System;
using System.Collections.Generic;
using TrainingUnit1.Models;

namespace TrainingUnit1.Controllers
{
    class EmployeeController
    {      

        List<Employee> employees = new List<Employee>();
        int numOfEmployee = 3;

        public void AddData()
        {
            employees.Add(new Employee(1, "Thinh", "Sale", "123456789"));
            employees.Add(new Employee(2, "Bach", "Sale", "123456789"));
            employees.Add(new Employee(3, "Phong", "Delivery", "123456789"));
            employees.Add(new Employee(4, "Quy", "Delivery", "123456789"));
            employees.Add(new Employee(5, "Dat", "Production", "123456789"));
        }
        

        public void ShowAll()
        {
            Console.WriteLine("SHOW ALL EMPLOYEES");
            Console.WriteLine("--------------------------------");

            if (numOfEmployee == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (Employee item in employees)
                {
                    item.Show();
                }
            }

            //implement the method of Interface class
            Console.Write("\nMission: ");
            employees[0].Work();
        }


        public void AddEmployee()
        {
            Console.WriteLine("ADD AN EMPLOYEE");
            Console.WriteLine("----------------------------------------");
            Console.Write("ID:");

            int id = int.Parse(Console.ReadLine());

            if (employees.Exists(x => x.ID == id))
            {
                Console.WriteLine("Exist ID");
                Console.Write("click ENTER to come back menu");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("--Name:");
                string name = Console.ReadLine();
                Console.WriteLine("--Department:");
                string department = Console.ReadLine();
                Console.WriteLine("--Number Phone:");
                string numberphone = Console.ReadLine();
                employees.Add(new Employee(id, name, department, numberphone));
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--\nAdd new employee Success");
                numOfEmployee++;
            }
        }


        public void EditEmployee()
        {
            Console.WriteLine("EDIT AN EMPLOYEE");
            Console.WriteLine("----------------------------------------");
            Console.Write("ID:");

            int editID = int.Parse(Console.ReadLine());
            string name;
            string department;
            string numberphone;

            if (employees.Exists(x => x.ID == editID))
            {
                foreach (Employee item in employees)
                {
                    if (item.ID == editID)
                    {
                        Console.WriteLine("--Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("--Department:");
                        department = Console.ReadLine();
                        Console.WriteLine("--Number Phone:");
                        numberphone = Console.ReadLine();
                        item.ID = editID;
                        item.Name = name;
                        item.Department = department;
                        item.NumberPhone = numberphone;
                        item.Role = "employee";
                        Console.WriteLine("\nEdit success");
                    }
                }
            }
            else
            {
                Console.WriteLine("No have this ID");
            }
        }


        public void FindEmployee()
        {
            Console.WriteLine("FIND AN EMPLOYEE");
            Console.WriteLine("----------------------------------------");
            Console.Write("ID:");
            int findID = int.Parse(Console.ReadLine());
            if (employees.Exists(x => x.ID == findID))
            {
                foreach (Employee item in employees)
                {
                    if (item.ID == findID)
                    {
                        Console.WriteLine($"\nInformation of ID: {findID}");
                        Console.WriteLine("--------------------------------");
                        item.Show();
                    }
                }
            }
            else
            {
                Console.WriteLine("No have this ID");
            }
        }

        public void removeEmployee()
        {
            Console.WriteLine("REMOVE AN EMPLOYEE");
            Console.WriteLine("----------------------------------------");
            Console.Write("ID:");

            int deleteEmployee = int.Parse(Console.ReadLine());

            if (employees.Exists(x => x.ID == deleteEmployee))
            {
                foreach (Employee item in employees)
                {
                    if (item.ID == deleteEmployee)
                    {
                        employees.Remove(item);
                        Console.WriteLine("\nDelete success");
                        numOfEmployee--;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No have this ID");
            }
        }


        //use HashSet to search a list of non-repeating items
        HashSet<Employee> bestEmployees = new HashSet<Employee>(3);

        public void ShowBestEmployees()
        {
            Console.WriteLine("BEST EMPLOYEES");
            Console.WriteLine("----------------------------------------");

            bestEmployees.Add(new Employee(1, "Thinh", "Sale", "123456789"));
            bestEmployees.Add(new Employee(2, "Bach", "Sale", "123456789"));
            bestEmployees.Add(new Employee(3, "Phong", "Delivery", "123456789"));

            foreach (var item in bestEmployees)
            {
                item.Show();
            }

            if (bestEmployees.IsSubsetOf(employees))
            {
                Console.WriteLine("\nThese employees are all of current employees");
            }
        }
    }
}
