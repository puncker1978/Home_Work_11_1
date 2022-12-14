// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;

namespace Home_Work_11_1
{
    abstract class Employee: Person, IClientDataMonitor
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор для инициализации сотрудника
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="thirdName">Отчество</param>
        internal Employee(string firstName, string secondName, string thirdName): base(firstName, secondName, thirdName)    
        {
        }

        
        #endregion

        #region Методы
        public override string ToString()
        {
            return $"Фамилия: {this.SecondName}\n" +
                $"Имя: {this.FirstName}\n" +
                $"Отчество: {this.ThirdName}\n" +
                $"Должность: {this.Position}";
        }

        public virtual string  ViewClientData(Client client)
        {
            throw new NotImplementedException();
        }

        public virtual void EditClientData(Client oldClientData, Client newClientData)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
