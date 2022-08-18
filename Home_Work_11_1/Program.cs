// This is a personal academic project. Dear PVS-Studio, please check it.

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

            #region Черновики
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
            #endregion

            #region Выбор Должности

            Console.WriteLine("Выберите должность");
            Console.WriteLine();

            ChoosePosition choosePosition = new ChoosePosition();
            Employee employee = choosePosition.SetPosition();

            if (employee != null)
            {
                Console.WriteLine($"Выбрана должность: {employee.Position}\n" +
                    $"Для продолжения нажмите Enter");
                Console.ReadKey();
                Console.Clear();
            };

            if (employee.GetType() == typeof(Consultant))
            {
                Menu menu = new ConsultantMenu();
                menu.DoAction(client, employee);
            }

            if (employee.GetType() == typeof(Manager))
            {
                Menu menu = new ManagerMenu();
                menu.DoAction(client, employee);
            }




            #endregion
        }
    }
}
