using System;

namespace TrainingUnit1.Models
{
    class Employee : Member, IWork
    {
        
        public string NumberPhone { get; set; }
        public Employee(int id, string name, string department, string numberphone)
        {
            ID = id;
            Name = name;
            Department = department;
            Role = "employee";
            NumberPhone = numberphone;
        }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}, Role: {Role}, Number Phone: {NumberPhone}");
        }

        public void Work()
        {
            Console.WriteLine("San xuat san pham");
        }
    }
}
