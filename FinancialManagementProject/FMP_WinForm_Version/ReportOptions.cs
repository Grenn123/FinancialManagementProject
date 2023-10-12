using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FMP_WinForm_Version
{
    public enum ReportOptions
    {
        /// <summary>
        /// "Все менеджеры"
        /// </summary>
        Managers = 1,

        /// <summary>
        /// "Все клиенты"
        /// </summary>
        Clients = 2,

        /// <summary>
        /// "Клиенты по менеджерам"
        /// </summary>
        CLientsToManagers = 3,

        /// <summary>
        /// "Все товары"
        /// </summary>
        Products = 4,

        /// <summary>
        /// "Товары по клиентам"
        /// </summary>
        ProductsToClients = 5,

        /// <summary>
        /// "Клиенты по статусам"
        /// </summary>
        ClientsToStatus = 6


        //При добавлении новых пунктов перечеисления необходимо добавить их в вывод комбобокса: AdministratorScreen.Entering_ComboBox()
    }
}
