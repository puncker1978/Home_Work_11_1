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
            menuItems = new string[8]
            {
                "Информация о клиенте",
                "Фамилия",
                "Имя",
                "Отчество",
                "Номер телефона",
                "Серия паспорта",
                "номер паспорта",
                "Выход"
            };
        }

        internal override void DoAction(Client client, Employee employee)
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
                                    Console.WriteLine(employee.ViewClientData(client));
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 1:
                                {
                                    Console.Write($"{menuItems[1]}\n" +
                                        $"Новая фамилия: ");
                                    string newSecondName = Console.ReadLine();
                                    client.SecondName = newSecondName;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                break;

                            case 2:
                                {
                                    Console.Write($"{menuItems[2]}\n" +
                                        $"Новое имя: ");
                                    string newFirstdName = Console.ReadLine();
                                    client.FirstName = newFirstdName;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 3:
                                {
                                    Console.Write($"{menuItems[3]}\n" +
                                        $"Новое отчество: ");
                                    string newThirdName = Console.ReadLine();
                                    client.ThirdName = newThirdName;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 4:
                                {
                                    Console.Write($"{menuItems[4]}\n" +
                                        $"Носвая фамилия: ");
                                    string newPhoneNumber = Console.ReadLine();
                                    client.PhoneNumber = newPhoneNumber;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 5:
                                {
                                    Console.Write($"{menuItems[5]}\n" +
                                        $"Новая серия паспорта: ");
                                    string newPassportSeries = Console.ReadLine();
                                    client.PassportSeries = newPassportSeries;
                                    ;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 6:
                                {
                                    Console.Write($"{menuItems[6]}\n" +
                                        $"Новый номер паспорта: ");
                                    string newPassportNumber = Console.ReadLine();
                                    client.PassportNumber = newPassportNumber;
                                    Console.WriteLine("Данные успешно изменены");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;

                            case 7:     //Выход
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
