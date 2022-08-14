// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    interface IClientDataMonitor
    {
        string ViewClientData(Client client);

        void EditClientData(Client oldClientData, Client newClientData);
    }
}
