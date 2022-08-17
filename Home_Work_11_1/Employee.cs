// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    class Employee: Person
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
        #endregion
    }
}
