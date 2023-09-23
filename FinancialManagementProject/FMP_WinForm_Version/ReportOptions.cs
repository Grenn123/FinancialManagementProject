using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FMP_WinForm_Version
{
    internal enum ReportOptions
    {
        [Description("Все менеджеры")]
        Managers = 1,

        [Description("Все клиенты")]
        Clients = 2,

        [Description("Клиенты по менеджерам")]
        CLientsToManagers = 3,

        [Description("Все товары")]
        Products = 4,

        [Description("Товары по клиентам")]
        ProductsToClients = 5,

        [Description("Клиенты по статусам")]
        ClientsToStatus = 6
    }
}
