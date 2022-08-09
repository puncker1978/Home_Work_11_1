// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    abstract class Employee: Person

    {
        #region Поля
        /// <summary>
        /// Должность
        /// </summary>
        private string position;
        #endregion

        #region Свойства
        /// <summary>
        /// Должность
        /// </summary>
        internal string Position { get => position; set => position = value; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор для инициализации сотрудника
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="thirdName">Отчество</param>
        /// <param name="position">Должность</param>
        protected Employee(string firstName,
            string secondName,
            string thirdName,
            string position): base(firstName, secondName, thirdName)    
        {
            this.Position = position;
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

        internal abstract void EditClientInformation(Client client, Client newClient);
        #endregion
    }
}
