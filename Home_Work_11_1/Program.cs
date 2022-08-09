// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;

namespace Home_Work_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Петров", "Сергеевич", "+7(925)347-25-14", "5304", "562578");
            Console.WriteLine(client);
            Console.ReadKey();
            Console.Clear();

            Employee consultant = new Employee("Дмитрий", "Иванов", "Анатольевич", "Консультант");
            Console.WriteLine(consultant);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(client.ViewedBy(consultant));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
