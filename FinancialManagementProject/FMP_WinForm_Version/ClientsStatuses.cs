using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMP_WinForm_Version
{
    public enum ClientsStatuses
    {
        /// <summary>
        /// "Все менеджеры"
        /// </summary>
        all = 1,

        /// <summary>
        /// "Обычные"
        /// </summary>
        usual = 2,

        /// <summary>
        /// "Ключевые"
        /// </summary>
        vip = 3


        //При добавлении новых пунктов перечеисления необходимо добавить их в вывод комбобокса: ManagerScreen.Entering_ComboBox_ClientStatus()

    }
}
