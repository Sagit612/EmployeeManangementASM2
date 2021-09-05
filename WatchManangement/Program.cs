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
            int input = MenuOption.INIT;
            string inputEmployee = MenuOption.INPUT_EMPLOYEE;
            Employee engineer1 = new Engineer("GCD123456", "Quốc", 18, "Male", "17 Dien Bien Phu", "Da Nang");
            managerEmployee.AddEmployee(engineer1);
            Employee engineer2 = new Engineer("GCD234567", "Đức", 18, "Male", "16 Ly Thai To", "Da Nang");
            managerEmployee.AddEmployee(engineer2);
            Employee engineer3 = new Engineer("GCD345678", "Nhan", 18, "Male", "03 Ham Nghi", "Da Nang");
            managerEmployee.AddEmployee(engineer3);
            Employee worker1 = new Worker("ASD234567", "Dũng", 18, "Male", "02 Hoang Hoa Tham", 5);
            managerEmployee.AddEmployee(worker1);
            Employee worker2 = new Worker("ASD123456", "Trí", 18, "Male", "02 Tran Van On", 5);
            managerEmployee.AddEmployee(worker2);
            while (input != MenuOption.EXIT)
            {
                input = IO.EnterMenuOptions();
                switch (input)
                {
                    case MenuOption.ADD_EMPLOYEES:
                        do
                        {
                            inputEmployee = IO.EnterEmployee();
                            switch (inputEmployee)
                            {
                                case MenuOption.ADD_ENGINEER:
                                    IO.EnterEngineer();
                                    Employee engineer = new Engineer
                                        (IO.EnterAndCheckId(managerEmployee),
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
                                        (IO.EnterAndCheckId(managerEmployee),
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
                    case MenuOption.EXIT:
                        return;
                    default:
                        break;
                }
                
            }
        }

    }
}
