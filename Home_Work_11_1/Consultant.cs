// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class Consultant : Employee, IClientDataMonitor
    {
        #region Конструктор
        internal Consultant(string firstName,
            string secondName,
            string thirdName,
            string position) : base(firstName,
                secondName, thirdName, position)
        {
        }
        #endregion

        #region Методы

        void IClientDataMonitor.EditClientData(Client oldClientData, Client newClientData)
        {
            //Консультант может изменить только номер телефона
            oldClientData.PhoneNumber = newClientData.PhoneNumber;
        }

        string IClientDataMonitor.ViewClientData(Client client)
        {
            string str = String.Format("Фамилия:{0,10} | Имя:{1,10} | Отчество: {2,10}")
            
            
            
            
            
            string str = "";
            str += $"(Консультант) Данные о клиенте:\n" +
                $"Фамилия: {client.SecondName}\n" +
                $"Имя: {client.FirstName}\n" +
                $"Отчество: {client.ThirdName}\n" +
                $"Номер телефона: {client.PhoneNumber}\n" +
                $"Серия паспорта: ****\n" +
                $"Номер паспорта: ******";
            return str;
            return String.Format("Name:{0,10} |  Level:{1,4} |  HitPoint:{2,6} |  Type:{3,12}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }


        #endregion
    }
}
