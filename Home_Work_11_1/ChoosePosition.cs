﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ChoosePosition : Menu
    {
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
    }
}