using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1.Program2.medium
{
    class EmployeePromotion
    {
        static void Main(String[] args)
        {
            //Entering the details of the employee with respect to the id number

            int no = 1; // to stop when the user wants
            Hashtable employees = new Hashtable();
            List<Employee> list = new List<Employee>();// to store values and to execute IComparable
            while (no == 1)
            {
                Employee e1 = new Employee();
                e1.TakeEmployeeDetailsFromUser();

                int key = e1.Id;
                string value = "Employee name: " + e1.Name + "\nEmployee Age: " + e1.Age + "\nEmployee Salary: " + e1.Salary;

                employees.Add(key, value);
                list.Add(e1);// stores all the values of an employee everytime it is entered

                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                no = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Make a choice");
            Console.WriteLine("1. To print the value based on the ID of the employee using key-value pair" +
                "\n2. To print the list of employeebased on the salary\n" +
                "And to produce the employee details using LINQ" +
                "\n3. To find the employee details based on the name" +
                "\n4. To print the employee details whose age is greater than the employee whose id is mentioned");
            int a = Convert.ToInt32(Console.ReadLine());

            string check = "y";
            if (a == 1)//key-value pair
            {
                check = "y";
            }
            else if (a == 2)//Sort based on salary and produce details using LINQ
            {
                SortAndPrintEmployees(list);
                PrintEmployees(list);
                check = "n";
            }
            else if (a == 3) //To print the emp details based on name given by the user
            {
                SortAndPrintEmployees(list);
                SameName(list);
                check = "n";
            }

            else if (a == 4) //To print the employee details whose age is greater than the employee whose id is mentioned
            {
                GreaterAge(list);
                check = "n";
            }


            while (check == "y")
            {
                //to print the details of the employee based on the key-Hashtable used

                Console.WriteLine("Please enter the employee ID");
                int id_no = Convert.ToInt32(Console.ReadLine());

                int flag = 0;
                foreach (Object o in employees.Keys)
                {
                    int Key = Convert.ToInt32(o.ToString());

                    if (Key == id_no)
                    {
                        Console.WriteLine("Employee ID:" + Key + "\n" + employees[o]);
                        flag = 1;
                        check = "n";
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("Sorry, The ID number does not exist. \nDo you want to try again-? y or n");
                    check = Console.ReadLine();
                }
            }





        }

        private static void SortAndPrintEmployees(List<Employee> list)
        {
            //The list is sorted based on salary
            Console.WriteLine("\n The Sorted employee list:");
            list.Sort();
            foreach (Employee e in list)
            {
                Console.WriteLine("\nEmployee ID : " + e.Id + "\nName : " + e.Name + "\nAge : " + e.Age + "\nSalary: " + e.Salary);
                Console.WriteLine("----------------------");
            }
        }

        //To print the details of an employee using LINQ by finding Employee id
        private static void PrintEmployees(List<Employee> list)
        {
            Console.WriteLine("Enter Employee id number:");
            int ID = Convert.ToInt32(Console.ReadLine());
            var empid = from e in list
                        where e.Id == ID
                        select e;
            foreach (var i in empid)
            {
                Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
            }
        }

        private static void SameName(List<Employee> list)
        {
            Console.WriteLine("Enter Employee Name:");
            string NAME = Console.ReadLine();
            var empname = from e in list
                          where e.Name == NAME
                          select e;
            foreach (var i in empname)
            {
                Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
                Console.WriteLine("---------------------");
            }
        }

        private static void GreaterAge(List<Employee> list)
        {
            int age = 0;
            Console.WriteLine("Enter Employee ID:");
            int ID = Convert.ToInt32(Console.ReadLine());
            foreach (Employee i in list)
            {
                if (i.Id == ID)
                {
                    age = i.Age;
                    break;
                }
                else
                    Console.WriteLine("The ID Number does not exists");
            }

            foreach (Employee i in list)
            {
                if (i.Age > age)
                {
                    Console.WriteLine("\nEmployee ID : " + i.Id + "\nName : " + i.Name + "\nAge : " + i.Age + "\nSalary: " + i.Salary);
                    Console.WriteLine("---------------------");
                }
            }
        }
    }
}
