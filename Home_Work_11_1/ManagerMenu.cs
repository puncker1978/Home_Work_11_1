﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ManagerMenu : Menu
    {
        internal ManagerMenu()
        {
            base.Row = Console.CursorTop;
            base.Column = Console.CursorLeft;
            base.Index = 0;
            menuItems = new string[7]
            {
                "Фамилия",
                "Имя",
                "Отчество",
                "Номер телефона",
                "Серия паспорта",
                "номер паспорта",
                "Выход"
            };
        }
    }
}