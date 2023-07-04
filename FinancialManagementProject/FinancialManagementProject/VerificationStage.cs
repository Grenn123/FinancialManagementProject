using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{
    internal enum VerificationStage
    {
        Login = 1,
        Password = 2,
        AccessIsAllowed = 3,
        AccessDenied = 4
    }
}
