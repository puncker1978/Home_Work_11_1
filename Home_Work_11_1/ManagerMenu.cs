// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ManagerMenu : Menu
    {
        internal ManagerMenu()
        {
            base.Row = Console.CursorTop;
            base.Column = Console.CursorLeft;
            base.Index = 0;
            menuItems = new string[7]
            {
                "Фамилия",
                "Имя",
                "Отчество",
                "Номер телефона",
                "Серия паспорта",
                "номер паспорта",
                "Выход"
            };
        }

        internal override void DoAction(Client client)
        {
            bool flag = true;
            while (flag)
            {
                DrawMenu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (Index < menuItems.Length - 1)
                            Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (Index > 0)
                            Index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (Index)
                        {
                            case 0:
                                {
                                    Console.WriteLine(menuItems[0]);
                                }
                                break;

                            case 1:
                                {
                                    Console.WriteLine(menuItems[1]);
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine(menuItems[2]);
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine(menuItems[3]);
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine(menuItems[4]);
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine(menuItems[5]);
                                }
                                break;

                            case 6:     //Выход
                                {
                                    Console.WriteLine($"Выбран пункт {menuItems[6]}\n" +
                                        $"Для выхода ещё раз нажмите Enter");
                                    Console.ReadKey();
                                    Console.Clear();
                                    flag = false;
                                }
                                break;
                        }
                        break;
                }
            }
        }
    }
}
