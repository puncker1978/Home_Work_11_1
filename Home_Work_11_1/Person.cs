// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com


namespace Home_Work_11_1
{
    abstract class Person
    {
        #region Поля
        /// <summary>
        /// Имя
        /// </summary>
        private string firstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string secondName;

        /// <summary>
        /// Отчество
        /// </summary>
        private string thirdName;

        /// <summary>
        /// Должность сотрудника: консультант либо менеджер. Либо клиент.
        /// </summary>
        private string position;
        #endregion

        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        internal string FirstName { get => firstName; set => firstName = value; }

        /// <summary>
        /// Фамилия
        /// </summary>
        internal string SecondName { get => secondName; set => secondName = value; }

        /// <summary>
        /// Отчество
        /// </summary>
        internal string ThirdName { get => thirdName; set => thirdName = value; }

        /// <summary>
        /// Должность сотрудника: консультант либо менеджер. Либо клиент.
        /// </summary>
        internal string Position { get => position; set => position = value; }

        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="thirdName">Отчество</param>
        protected Person(string firstName, string secondName, string thirdName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
        }
        #endregion

        #region Методы
        #endregion
    }
}
