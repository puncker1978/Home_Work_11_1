using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ChoosePosition
    {
        //Положение курсора
        private int row;
        private int column;

        //Индекс массива заголовков меню
        private int index;

        //Пункты меню
        internal string[] menuItems = new string[]
        {
            "Консультант",
            "Менеджер",
            "Выход"
        };

        //Индекс массива заголовков меню
        internal int Index { get => index; set => index = value; }

            internal ChoosePosition()
            {
                this.row = Console.CursorTop;
                this.column = Console.CursorLeft;
                this.index = 0;
            }

            internal void DrawMenu()
            {
                Console.SetCursorPosition(column, row);
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == index)
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