using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementProject
{

    internal class DataSaving
    {
        internal static string userLogin { get; private set; } = "123";
        internal static string userPassword { get; private set; } = "234";
        internal static int quantityOfPlans { get; private set; }
        internal int indexOfLine { get; private set; } //Индекс следующей свободной ячейки


        //Создание коллекция для хранения пар значений
        internal Dictionary<string, string> userLoginAndPassword = new Dictionary<string, string>();
        internal Dictionary<string, string> userPlans = new Dictionary<string, string>();

        internal void UserLoginAndPasswordSaving(string userLogin, string userPassword)
        {
            DataSaving.userLogin = userLogin;
            DataSaving.userPassword = userPassword;

            userLoginAndPassword.Add(userLogin, userPassword);
            indexOfLine++;
        }

        internal void SavingNameOfNewPlan(string nameOfPlan)
        {
            userPlans.Add(DataSaving.userLogin, nameOfPlan);
            quantityOfPlans++;
        }
    }
}
