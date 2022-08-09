// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;

namespace Home_Work_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Петров", "Сергеевич", "+7(925)111-11-11", "5304", "562578");
            Console.WriteLine(client);
            Console.ReadKey();
            Console.Clear();

            Employee consultant = new Consultant("Дмитрий", "Иванов", "Анатольевич", "Консультант");
            Console.WriteLine(consultant);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(client.ViewedBy(consultant));
            Console.ReadKey();
            Console.Clear();

            Client newClient = new Client("Иван", "Иванов", "Сергеевич", "+7(905)222-22-22", "5304", "562578");
            //Поскольку Консультант пытается изменить информацию
            //не только про телефон, но и фамилию клиента, то изменится только телефон,
            //а фамилия останется прежней
            consultant.EditClientInformation(client, newClient);
            Console.WriteLine(client.ViewedBy(consultant));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
