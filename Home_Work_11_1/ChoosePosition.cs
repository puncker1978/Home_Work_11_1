// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ChoosePosition : Menu
    {
        /// <summary>
        /// Метод выбора должности
        /// </summary>
        internal ChoosePosition()
        {
            base.Row = Console.CursorTop;
            base.Column = Console.CursorLeft;
            base.Index = 0;
            menuItems = new string[3]
            {
                "Консультант",
                "Менеджер",
                "Выход"
            };
        }

        /// <summary>
        /// Метод устанавливает для данного сотрудника его должность
        /// </summary>
        /// <param name="employee">Сотрудник</param>
        /// <param name="choosePosition">Должность</param>
        /// <returns></returns>
        internal Employee SetPosition(Employee employee, ChoosePosition choosePosition)
        {
            bool flag = true;
            while (flag)
            {
                choosePosition.DrawMenu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (choosePosition.Index < choosePosition.menuItems.Length - 1)
                            choosePosition.Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (choosePosition.Index > 0)
                            choosePosition.Index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (choosePosition.Index)
                        {
                            case 0:     //Консультант
                                {
                                    Console.Clear();

                                    string position = "Консультант";
                                    employee.Position = position;

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 1:     //Менеджер
                                {
                                    Console.Clear();

                                    string position = "Менеджер";
                                    employee.Position = position;

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 2:     //Выход
                                {
                                    Console.WriteLine($"Выбран пункт \"Выход\"\nДля выхода ещё раз нажмите Enter");
                                    Console.ReadKey();
                                    Console.Clear();
                                    flag = false;
                                }
                                break;
                        }
                        break;
                }
            }
            return employee;
        }
    }
}
