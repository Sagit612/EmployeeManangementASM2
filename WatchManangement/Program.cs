using EmployeeManagement;
using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerEmployee managerEmployee = new ManagerEmployee();
            IO.PrintMenu();
            int input = 0;
            string inputEmployee = "";
            //Employee engineer1 = new Engineer("GCD28290", "quoc", 18, "male", "17 dien bien phu", "software");
            //managerEmployee.AddEmployee(engineer1);
            //Employee engineer2 = new Engineer("GCD201870", "quoc", 18, "male", "17 dien bien phu", "software");
            //managerEmployee.AddEmployee(engineer2);
            //Employee engineer3 = new Engineer("GCD291248", "quoc", 18, "male", "17 dien bien phu", "software");
            //managerEmployee.AddEmployee(engineer3);
            //Employee engineer4 = new Engineer("GCD212734", "quoc", 18, "male", "17 dien bien phu", "software");
            //managerEmployee.AddEmployee(engineer4);
            //Employee engineer5 = new Engineer("GCD123494", "quoc", 18, "male", "17 dien bien phu", "software");
            //managerEmployee.AddEmployee(engineer5);
            //Employee Worker6 = new Worker("ASD684335", "quoc", 18, "male", "17 dien bien phu", 7);
            //managerEmployee.AddEmployee(Worker6);
            //Employee Worker7 = new Worker("ASD589430", "quoc", 18, "male", "17 dien bien phu", 8);
            //managerEmployee.AddEmployee(Worker7);
            //Employee Worker8 = new Worker("ASD683934", "quoc", 18, "male", "17 dien bien phu", 9);
            //managerEmployee.AddEmployee(Worker8);

            while (true)
            {
                input = IO.EnterMenuOptions();
                switch (input)
                {
                    case MenuOption.ADD_EMPLOYEES:
                        do
                        {
                            inputEmployee = IO.EnterOfficer();
                            switch (inputEmployee)
                            {
                                case MenuOption.ADD_ENGINEER:
                                    IO.EnterEngineer();
                                    Employee engineer = new Engineer
                                        (IO.EnterId(managerEmployee),
                                         IO.EnterName(),
                                         IO.EnterAge(),
                                         IO.EnterGender(),
                                         IO.EnterAddress(),
                                         IO.EnterBranch());
                                    managerEmployee.AddEmployee(engineer);
                                    break;
                                case MenuOption.ADD_WORKER:
                                    IO.EnterWoker();
                                    Employee worker = new Worker
                                        (IO.EnterId(managerEmployee),
                                         IO.EnterName(),
                                         IO.EnterAge(),
                                         IO.EnterGender(),
                                         IO.EnterAddress(),
                                         IO.EnterLevel());
                                    managerEmployee.AddEmployee(worker);
                                    break;
                                case MenuOption.EXIT_ENTER_OFFICER:
                                    inputEmployee = MenuOption.EXIT_ENTER_OFFICER;
                                    break;
                                default:
                                    break;
                            }
                        } while (inputEmployee != MenuOption.EXIT_ENTER_OFFICER);
                        break;
                    case MenuOption.GET_ALL:
                        IO.ToScreen(managerEmployee.GetAllEmployeeInfo());
                        break;
                    case MenuOption.REMOVE_EMPLOYEE:
                        IO.ShowMessage(managerEmployee.RemoveEmployeeById(IO.EnterId()));
                        break;
                    case MenuOption.SEARCH_BY_ID:
                        IO.ToScreen(managerEmployee.SearchEmployeeById(IO.EnterId()));
                        break;
                    case MenuOption.UPDATE_ENGINEER:
                        IO.ShowMessage(managerEmployee.UpdateEngineerById
                            (IO.EnterId(),
                             IO.EnterName(),
                             IO.EnterAge(),
                             IO.EnterGender(),
                             IO.EnterAddress(),
                             IO.EnterBranch()
                            ));
                        break;
                    case MenuOption.UPDATE_WORKER:
                        IO.ShowMessage(managerEmployee.UpdateWorkerById
                            (IO.EnterId(),
                             IO.EnterName(),
                             IO.EnterAge(),
                             IO.EnterGender(),
                             IO.EnterAddress(),
                             IO.EnterLevel()
                            ));
                        break;
                    case MenuOption.COUNT_EMPLOYEES:
                        IO.ShowNumberOfficer(managerEmployee.CountEmployees());
                        break;
                    case MenuOption.EXIT:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
