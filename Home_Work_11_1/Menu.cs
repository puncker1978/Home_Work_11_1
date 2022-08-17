// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    abstract class Menu
    {
        #region Поля
        /// <summary>
        /// Положение курсора
        /// </summary>
        private int row;
        private int column;

        /// <summary>
        /// Индекс массива заголовков меню
        /// </summary>
        private int index;
        #endregion

        #region Свойства
        internal int Row { get => row; set => row = value; }
        internal int Column { get => column; set => column = value; }
        internal int Index { get => index; set => index = value; }
        #endregion

        /// <summary>
        /// Пункты меню
        /// Для должности(консультант либо менеджер)
        /// Для сотрудников - выбор поля для редактирования
        /// </summary>
        internal string[] menuItems;
      
        /// <summary>
        /// Метод отрисовки меню
        /// </summary>
        internal void DrawMenu()
        {
            Console.SetCursorPosition(Column, Row);
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == Index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
