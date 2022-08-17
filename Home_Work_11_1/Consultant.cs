// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class Consultant : Employee, IClientDataMonitor
    {
        #region Константы
        internal const string position = "Консультант";
        #endregion

        #region Конструктор
        internal Consultant(string firstName,
            string secondName,
            string thirdName) : base(firstName,
                secondName, thirdName)
        {
            this.Position = position;
        }

        #endregion

        #region Методы

        public override void  EditClientData(Client oldClientData, Client newClientData)
        {
            //Консультант может изменить только номер телефона
            oldClientData.PhoneNumber = newClientData.PhoneNumber;
        }

        public override string ViewClientData(Client client)
        {
            string str = "";
            str += $"Данные о клиенте:\n" +
                $"Фамилия: {client.SecondName}\n" +
                $"Имя: {client.FirstName}\n" +
                $"Отчество: {client.ThirdName}\n" +
                $"Номер телефона: {client.PhoneNumber}\n" +
                $"Серия паспорта: ****\n" +
                $"Номер паспорта: ******";
            return str;
        }
        #endregion
    }
}
