using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace EmployeeManagement
{
    class MenuOption
    {
        public const int INIT = 0;
        public const int ADD_EMPLOYEES = 1;
        public const int GET_ALL = 2;
        public const int REMOVE_EMPLOYEE = 3;
        public const int SEARCH_BY_ID = 4;
        public const int UPDATE_ENGINEER = 5;
        public const int UPDATE_WORKER = 6;
        public const int COUNT_EMPLOYEES = 7;
        // TODO
        public const int SEARCH_BY_CLASS_NAME = 8;
        public const int SEARCH_BY_AGE = 9;
        public const int SEARCH_BY_MARK = 9;
        public const int EXIT = 10;

        public const string ADD_ENGINEER = "a";
        public const string ADD_WORKER = "b";
        public const string EXIT_ENTER_OFFICER = "v";
    }
    class IO
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\t\t\t\t\t=========Welcome to program=========");
            Console.WriteLine("\t\t\t\t\t====================================");
        }
        public static int EnterMenuOptions()
        {
            Console.WriteLine("\t\t\t\t|\t1: To add officer                  \t|");
            Console.WriteLine("\t\t\t\t|\t2: To show information of officier \t|");
            Console.WriteLine("\t\t\t\t|\t3: To remove employee by id        \t|");
            Console.WriteLine("\t\t\t\t|\t4: To search employee by id        \t|");
            Console.WriteLine("\t\t\t\t|\t5: To update engineer by id        \t|");
            Console.WriteLine("\t\t\t\t|\t6: To update worker by id          \t|");
            Console.WriteLine("\t\t\t\t|\t7: To count employee(s)            \t|");
            Console.WriteLine("\t\t\t\t|\t10: To exit                        \t|");
            Console.Write("\t\t\t\t\tEnter your choice:  ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterOfficer() 
        {
            Console.WriteLine("\t\t\t\t\t====================================");
            Console.WriteLine("\t\t\t\t|\t   Enter \"a\" to add Engineer     \t|");
            Console.WriteLine("\t\t\t\t|\t   Enter \"b\" to add Worker       \t|");
            Console.WriteLine("\t\t\t\t|\t   Enter \"v\" to exit             \t|");
            Console.Write("\t\t\t\t\tEnter your choice:  ");
            return Console.ReadLine();
        }
        public static void EnterEngineer() 
        {
            Console.WriteLine("\t\t\t\t\t====================================");
            Console.WriteLine("\tEnter the information of engineer:");
        }
        public static void EnterWoker()
        {
            Console.WriteLine("\t\t\t\t\t====================================");
            Console.WriteLine("\tEnter the information of worker:");
        }
        public static string EnterId(ManagerEmployee managerEmployee)
        {
            string id = "";
            inputAgain:
            Console.Write("\t>> Enter ID: ");
            id = Console.ReadLine();
            bool status = managerEmployee.CheckEmployeeById(id);
            if (status)
            {
                Console.WriteLine("\t****ID is reduplicated");
                goto inputAgain;
            }
            return id;
            
        }
        public static string EnterId()
        {
            Console.Write("\t>> Enter ID: ");
            return Console.ReadLine();
        }
        public static void EnterIdAgain()
        {
            Console.WriteLine("This ID is exist, please enter again!!!");
        }
        public static string EnterName()
        {
            Console.Write("\t>> Enter name: ");
            return Console.ReadLine();
        }
        public static int EnterAge()
        {
            inputAgain:
            Console.Write("\t>> Enter age: ");
            int age = int.Parse(Console.ReadLine());
            if (age > 100)
            {
                Console.WriteLine("\t***Age is not greater than 100!!! Please input again!!!");
                goto inputAgain;
            }
            if (age <= 0)
            {
                Console.WriteLine("\t***Age is not lower than 0!!! Please input again!!!");
                goto inputAgain;
            }
            return age;
        }
        public static string EnterGender()
        {
            Console.Write("\t>> Enter gender: ");
            return Console.ReadLine();
        }
        public static string EnterAddress()
        {
            Console.Write("\t>> Enter address: ");
            return Console.ReadLine();
        }
        public static string EnterBranch()
        {
            Console.Write("\t>> Enter branch: ");
            return Console.ReadLine();
        }
        public static int EnterLevel()
        {
            Console.Write("\t>> Enter level:");
            return int.Parse(Console.ReadLine());
        }
        public static void ToScreen(string str)
        {
            if (str.Length == 0) Console.WriteLine("There is no employee, please input employee");
            else Console.WriteLine(str);
        }
        public static void ShowMessage(bool status)
        {
            if (status) Console.WriteLine("\tSUCCESSFUL!!!");
            else Console.WriteLine("\tFAILED!!! ID doesn't exist!!");
        }
        public static void ShowNumberOfficer(int numberOfficer)
        {
            if (numberOfficer == 1)
            {
                Console.WriteLine($"There is {numberOfficer} officer");
            }
            Console.WriteLine($"There are {numberOfficer} officers");
        }
    }
}
