// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;

namespace Home_Work_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Петров", "Сергеевич", "+7(925)111-11-11", "5304", "562578");

            Client client1 = new Client("Александр", "Петров", "Сергеевич", "+7(925)111-11-12", "5304", "562578");

            Client client2 = new Client("Александр", "Петров", "Сергеевич", "+7(925)111-11-13", "5304", "562578");
            
            Console.WriteLine(client);
            Console.WriteLine(client1);
            Console.WriteLine(client2);
            Console.ReadKey();
            Console.Clear();

            Employee employee1 = new Consultant("Дмитрий", "Иванов", "Анатольевич", "Консультант");
            (employee1 as IClientDataMonitor).EditClientData(client, client1);
            Console.ReadKey();
            Console.WriteLine((employee1 as IClientDataMonitor).ViewClientData(client));
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine(client);
            //Console.ReadKey();
            //Console.Clear();

            //Employee employee2 = new Manager("Сергей", "Сидоров", "Игоревич", "Менеджер");
            //Console.WriteLine(employee2.GetType());
            //((IClientDataMonitor)employee2).EditClientData(client, client1);
            //Console.ReadKey();
            //Console.Clear();

            

            
        }
    }
}
