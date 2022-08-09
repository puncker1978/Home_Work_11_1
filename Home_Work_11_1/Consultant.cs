// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal class Consultant : Employee
    {
        internal Consultant(string firstName,
            string secondName,
            string thirdName,
            string position) : base(firstName,
                secondName, thirdName, position)
        {
        }

        internal override void EditClientInformation(Client client, Client newClient)
        {
            //Консультант может изменить только номер телефона
            client.PhoneNumber = newClient.PhoneNumber;
        }
    }
}
