﻿// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Home_Work_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Петров", "Сергеевич", "+7(925)111-11-11", "5304", "562578");

            Client client1 = new Client("Александр", "Петров", "Сергеевич", "+7(925)111-11-12", "5304", "562578");

            Client client2 = new Client("Александр", "Петров", "Сергеевич", "+7(925)111-11-13", "5304", "562578");
            
            //Console.WriteLine(client);
            //Console.WriteLine(client1);
            //Console.WriteLine(client2);
            //Console.ReadKey();
            //Console.Clear();


            //IClientDataMonitor employee1 = new Consultant("Дмитрий", "Иванов", "Анатольевич", "Консультант");
            //employee1.EditClientData(client, client1);
            //Console.ReadKey();
            //Console.WriteLine((employee1 as IClientDataMonitor).ViewClientData(client));
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine(client);
            //Console.ReadKey();
            //Console.Clear();


            //Employee employee2 = new Manager("Сергей", "Сидоров", "Игоревич", "Менеджер");
            //Console.WriteLine(employee2.GetType());
            //((IClientDataMonitor)employee2).EditClientData(client, client1);
            //Console.ReadKey();
            //Console.Clear();

            #region Выбор Должности
            {
                Console.WriteLine("Выберите должность");
                Console.WriteLine();

                ChoosePosition choosePosition = new ChoosePosition();

                while (true)
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
                                        Employee employee = new Consultant("Дмитрий",
                                            "Иванов",
                                            "Анатольевич",
                                            position);
                                        Console.WriteLine("Выберите действие:");
                                        Console.WriteLine();

                                        ConsultantMenu consultantMenu = new ConsultantMenu();
                                        bool flag = true;
                                        while (flag)
                                        {
                                            consultantMenu.DrawMenu();
                                            switch (Console.ReadKey(true).Key)
                                            {
                                                case ConsoleKey.DownArrow:
                                                    if (consultantMenu.Index < consultantMenu.menuItems.Length - 1)
                                                        consultantMenu.Index++;
                                                    break;

                                                case ConsoleKey.UpArrow:
                                                    if (consultantMenu.Index > 0)
                                                        consultantMenu.Index--;
                                                    break;

                                                case ConsoleKey.Enter:
                                                    switch (consultantMenu.Index)
                                                    {
                                                        case 0:  //Просмотр информации о клиенте
                                                            {
                                                                Console.WriteLine($"{employee.SecondName}\t" +
                                                                $"{employee.FirstName}\t" +
                                                                $"{employee.ThirdName}\t" +
                                                                $"({employee.Position})\n");

                                                                Console.WriteLine((employee as IClientDataMonitor).ViewClientData(client));
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;
                                                        case 1:  //Редактирование информации о клиенте
                                                            {
                                                                Console.Write("Введите новый номер телефона: ");
                                                                string phoneNumber = Console.ReadLine();
                                                                if (phoneNumber != null || phoneNumber != "")
                                                                {
                                                                    client.PhoneNumber = phoneNumber;
                                                                }
                                                                Console.WriteLine("Номер телефона изменён");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            break;
                                                        case 2:  //Выход
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
                                        break;

                                    }

                                case 1:     //Менеджер
                                    {   
                                        Console.Clear();

                                        string position = "Менеджер";
                                        Employee employee = new Manager("Сергей",
                                            "Сидоров",
                                            "Игоревич",
                                            position);

                                        Console.WriteLine($"{employee.SecondName}\t" +
                                            $"{employee.FirstName}\t" +
                                            $"{employee.ThirdName}\t" +
                                            $"({employee.Position})\n");

                                        Console.WriteLine((employee as IClientDataMonitor).ViewClientData(client));

                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    break;
                                case 2:     //Выход
                                    {
                                        Console.WriteLine($"Выбран пункт \"Выход\"\nДля выхода ещё раз нажмите Enter");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    break;
                            }
                            return;
                    }
                }
            }
            #endregion


        }
    }
}
