// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;

namespace Home_Work_11_1
{
    internal class ChoosePosition : Menu
    {
        /// <summary>
        /// Метод выбора должности
        /// </summary>
        internal ChoosePosition()
        {
            base.Row = Console.CursorTop;
            base.Column = Console.CursorLeft;
            base.Index = 0;
            menuItems = new string[3]
            {
                "Консультант",
                "Менеджер",
                "Выход"
            };
        }

        /// <summary>
        /// Метод устанавливает класс, соответствующий выбранной в меню должности.
        /// </summary>
        /// <param name="choosePosition">Должность, выбранная в меню</param>
        /// <returns>Соответствующий класс</returns>
        internal Employee SetPosition(ChoosePosition choosePosition)
        {
            Employee employee = null;
            bool flag = true;
            while (flag)
            {
                choosePosition.DrawMenu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (choosePosition.Index < choosePosition.menuItems.Length - 1)
                            choosePosition.Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (choosePosition.Index > 0)
                            choosePosition.Index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (choosePosition.Index)
                        {
                            case 0:     //Консультант
                                {
                                    employee = new Consultant("Иван", "Николаев", "Федорович");
                                }
                                break;

                            case 1:     //Менеджер
                                {
                                    employee = new Manager("Пётр", "Ильин", "Сергеевич");
                                }
                                break;
                            case 2:     //Выход
                                {
                                    Console.WriteLine($"Выбран пункт \"Выход\"\n" +
                                        $"Для выхода ещё раз нажмите Enter");
                                    Console.ReadKey();
                                    Console.Clear();
                                    flag = false;
                                }
                                break;
                        }
                        break;
                }
            }
            return employee;
        }
    }
}
