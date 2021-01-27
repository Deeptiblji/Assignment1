using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1.Program3.hard
{
    class EmployeePromotion
    {
        static void Main(String[] args)
        {

            List<Employee> list = new List<Employee>();
            int ch = DisplayMenu();
            int check = 1;
            while (check == 1)
            {
                switch (ch)
                {
                    case 1:
                        AddEmployee(list);
                        ch = DisplayMenu();
                        break;

                    case 2:

                        ModifyEmployee(list);
                        ch = DisplayMenu();
                        break;
                    case 3:

                        PrintEmployee(list);
                        ch = DisplayMenu();
                        break;
                    case 4:
                        EmployeeDetail(list);
                        ch = DisplayMenu();
                        break;
                    case 5:
                        check = 0;
                        break;

                    default:
                        Console.WriteLine("The choice entered is Wrong. Please insert the right choice");
                        ch = DisplayMenu();
                        break;
                }
            }

        }

        private static int DisplayMenu()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Please Enter the option:" +
                "\n1. Add an Employee" +
                "\n2. Modify an Employee Detail" +
                "\n3.Print all Employee Details" +
                "\n4. Print an Employee Detail" +
                "\n5.Exit");
            Console.WriteLine("-------------------");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private static void AddEmployee(List<Employee> list)
        {
            Employee e1 = new Employee();
            e1.TakeEmployeeDetailsFromUser();
            list.Add(e1);
        }

        private static void ModifyEmployee(List<Employee> list)
        {
            Console.WriteLine("Enter Employee id number:");
            int ID = Convert.ToInt32(Console.ReadLine());
            var empid = from e in list
                        where e.Id == ID
                        select e;
            Console.WriteLine("The Employee Details:");
            foreach (var i in empid)
            {
                Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
            }
            Console.WriteLine("\nPlease enter the updated employee details");
            Console.WriteLine("Please enter the employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            var modify = from e in list
                         where e.Id == ID
                         select e;
            foreach (var i in modify)
            {
                i.Name = name;
                i.Age = age;
                i.Salary = salary;
            }
        }

        private static void PrintEmployee(List<Employee> list)
        {
            foreach (Employee i in list)
            {
                Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
                Console.WriteLine("-------------------");
            }
        }

        private static void EmployeeDetail(List<Employee> list)
        {
            Console.WriteLine("Enter Employee id number:");
            int ID = Convert.ToInt32(Console.ReadLine());
            var EmpId = from e in list
                        where e.Id == ID
                        select e;
            foreach (var i in EmpId)
            {
                Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
                Console.WriteLine("-------------------");
            }
        }
    }
}
