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
            Row = Console.CursorTop;
            Column = Console.CursorLeft;
            Index = 0;
            menuItems = new string[2]
            {
                "Консультант",
                "Менеджер"
            };
        }

        /// <summary>
        /// Метод устанавливает класс, соответствующий выбранной в меню должности.
        /// </summary>
        /// <param name="choosePosition">Должность, выбранная в меню</param>
        /// <returns>Соответствующий класс</returns>
        internal Employee SetPosition()
        {
            Employee employee = null;
            bool flag = true;
            while (flag)
            {
                DrawMenu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (Index < menuItems.Length - 1)
                            Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (Index > 0)
                            Index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (Index)
                        {
                            case 0:     //Консультант
                                {
                                    employee = new Consultant("Иван", "Николаев", "Федорович");
                                    flag = false;
                                }
                                break;

                            case 1:     //Менеджер
                                {
                                    employee = new Manager("Пётр", "Ильин", "Сергеевич");
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
