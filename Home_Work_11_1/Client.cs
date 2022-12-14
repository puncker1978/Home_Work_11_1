// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace Home_Work_11_1
{
    /// <summary>
    /// Клиент
    /// </summary>
    internal class Client : Person
    {
        #region Поля

        /// <summary>
        /// Номер телефона
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Серия паспорта
        /// </summary>
        private string passportSeries;

        /// <summary>
        /// Номер паспорта
        /// </summary>
        private string passportNumber;
        #endregion

        #region Свойства

        /// <summary>
        /// Номер телефона
        /// </summary>
        internal string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        internal string PassportSeries { get => passportSeries; set => passportSeries = value; }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        internal string PassportNumber { get => passportNumber; set => passportNumber = value; }
        #endregion

        #region Конструктор
        /// <summary>
        /// Клиент
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="thirdName">Отчество</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="passportSeries">Серия паспорта</param>
        /// <param name="passportNumber">Номер паспорта</param>
        internal Client(string firstName,
            string secondName,
            string thirdName,
            string phoneNumber,
            string passportSeries,
            string passportNumber) : base(firstName, secondName, thirdName)
        {
            Position = "Клиент";
            PhoneNumber = phoneNumber;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }
        #endregion

        #region Методы
        public override string ToString()
        {
             return $"================================\n" +
                $"|Фамилия: {this.SecondName}\n" +
                $"|Имя: {this.FirstName}\n" +
                $"|Отчество: {this.ThirdName}\n" +
                $"|Номер телефона: {this.PhoneNumber}\n" +
                $"|Серия паспорта: {this.PassportSeries}\n" +
                $"|Номер паспорта: {this.PassportNumber}\n" +
                $"================================\n";
        }

        internal string ViewedBy(Employee employee)
        {
            string str = $"Фамилия: {this.SecondName}\n" +
                    $"Имя: {this.FirstName}\n" +
                    $"Отчество: {this.ThirdName}\n" +
                    $"Номер телефона: {this.PhoneNumber}\n";
            if (employee is Consultant)
            {
                str += $"Серия паспорта: ******\n" +
                    $"Номер паспорта: ****";
            }
            else
            {

            }
            return str;
        }
        #endregion
    }
}
