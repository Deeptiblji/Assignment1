using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Program1.easy
{
    class EmployeePromotion
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            string input = Console.ReadLine();
            ArrayList names = new ArrayList();
            while (input != "")
            {

                names.Add(input);
                input = Console.ReadLine();
            }


            string tocont = "y"; //used so thta the user can access the program as much as he wants..it will stop only when the user needs it to
            while (tocont == "y")
            {
                Console.WriteLine("Chose the option:");
                Console.WriteLine("1. For checking the promotion position of the employee");
                Console.WriteLine("2. To remove the extra space of the employee list");
                Console.WriteLine("3. For viewing the promoted list of employees in ascending order");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //for checking promotion of the employee
                        Console.WriteLine("Please enter the name of the employee to check promotion position");
                        string emp = Console.ReadLine();
                        int flag = 0; //to make sure if the employee is in the list
                        foreach (string i in names)
                        {
                            if (i == emp)
                            {
                                int b = (names.IndexOf(i)) + 1;
                                Console.WriteLine(emp + " is in the position " + b + " for promotion");
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("The name that you have entered is not eligible for promotion.");
                        }
                        Console.WriteLine("Do you want to continue? y or n..");
                        tocont = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Do you want to continue? y or n..");
                        tocont = Console.ReadLine();
                        break;
                    case 3:
                        //ascending order of the employees
                        names.Sort();
                        Console.WriteLine("Promoted employee list");
                        foreach (string i in names)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Do you want to continue? y or n..");
                        tocont = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("You have entered the wrong choice");
                        Console.WriteLine("Do you want to continue? y or n..");
                        tocont = Console.ReadLine();
                        break;
                }
            }

        }
    }
}
