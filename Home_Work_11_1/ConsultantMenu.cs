// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ConsultantMenu : Menu
    {
        internal ConsultantMenu()
        {
            Row = Console.CursorTop;
            Column = Console.CursorLeft;
            Index = 0;
            menuItems = new string[3]
            {
                "Информация о клиенте",
                "Новый номер телефона",
                "Выход"
            };
        }

        internal override void  DoAction(Client client, Employee employee)
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
                                    Console.WriteLine(client);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 1:    
                                {
                                    Console.WriteLine(menuItems[1]);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 2:     //Выход
                                {
                                    Console.WriteLine($"Выбран пункт {menuItems[2]}\n" +
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
