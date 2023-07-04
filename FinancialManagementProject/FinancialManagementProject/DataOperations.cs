using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementProject
{
    internal class DataOperations  //abstract??
    {
        protected static string UserLogin { get; private set; }
        protected static string UserPassword { get; private set; }
        internal static int QuantityOfPlans { get; private set; }

        private string UserId;
        private int indexOfLine;


        //Создание коллекция для хранения пар значений
        internal Dictionary<string, string> userLoginAndPassword = new Dictionary<string, string>();
        internal Dictionary<string, string> userPlans = new Dictionary<string, string>();


        internal void DataLoading()
        {
            UserLogin = "123";
            UserPassword = "234";
            QuantityOfPlans = 0;
        }

        internal void UserLoginAndPasswordSaving()
        {
            UserLogin = RegistrationMenu.registrationUserLogin;
            UserPassword = RegistrationMenu.UserPassword;

            GenerateUserId();

            userLoginAndPassword.Add(UserLogin, UserPassword);
            indexOfLine++;
        }

        internal void SavingNameOfNewPlan()
        {
            userPlans.Add(UserLogin, PlanCreationMenu.nameOfPlan);
            QuantityOfPlans++;
        }

        private void GenerateUserId()
        {
            UserId = Guid.NewGuid().ToString();
        }
    }
}
