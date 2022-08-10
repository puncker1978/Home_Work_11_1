// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_11_1
{
    internal interface IClientDataMonitor
    {
        internal string ViewClientData(Client client);

        public void EditClientData(Client oldClientData, Client newClientData);
    }
}
