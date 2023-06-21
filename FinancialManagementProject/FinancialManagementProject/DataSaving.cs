using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{

    internal class DataSaving
    {
        internal string userName { get; private set; } = "123";
        internal string userPassword { get; private set; } = "123";

        internal int quantityOfPlans { get; set; } = 0;

        internal Dictionary<string, string> userLoginAndPassword = new Dictionary<string, string>();
    }
}
