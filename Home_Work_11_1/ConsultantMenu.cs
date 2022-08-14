// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class ConsultantMenu : Menu
    {
        internal ConsultantMenu()
        {
            base.Row = Console.CursorTop;
            base.Column = Console.CursorLeft;
            base.Index = 0;
            menuItems = new string[2]
            {
                "Номер телефона",
                "Выход"
            };
        }
    }
}
