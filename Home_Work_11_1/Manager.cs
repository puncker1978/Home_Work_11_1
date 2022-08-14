// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class Manager : Employee, IClientDataMonitor
    {
        #region Конструкторы
        public Manager(string firstName,
            string secondName,
            string thirdName,
            string position) : base(firstName, secondName, thirdName, position)
        {
        }
        #endregion

        #region Методы

        public void EditClientData(Client oldClientData, Client newClientData)
        {
            oldClientData = newClientData;
        }

        public string ViewClientData(Client client)
        {
            string str = "";
            str += $"Данные о клиенте:\n" +
                $"Фамилия: {client.SecondName}\n" +
                $"Имя: {client.FirstName}\n" +
                $"Отчество: {client.ThirdName}\n" +
                $"Номер телефона: {client.PhoneNumber}\n" +
                $"Серия паспорта: {client.PassportSeries}\n" +
                $"Номер паспорта: {client.PassportNumber}";
            return str;
        }
        #endregion
    }
}
