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
        protected string UserLogin { get; private set; }
        protected string UserPassword { get; private set; }
        internal int QuantityOfPlans { get; private set; }


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
            UserLogin = Program.registrationMenu.registrationUserLogin;
            UserPassword = Program.registrationMenu.registrationUserPassword;

            GenerateUserId();

            userLoginAndPassword.Add(UserLogin, UserPassword);

        }

        internal void SavingNameOfNewPlan()
        {
            userPlans.Add(UserLogin, Program.planCreationMenu.columnName);
            QuantityOfPlans++;
        }

        //Нигде не используется
        private void GenerateUserId()
        {
            Program.userID = Guid.NewGuid().ToString();
        }

        internal void ShowAllPlansOfUser()
        {
            Console.WriteLine($"Список всех планов пользователя {UserLogin}");
            foreach (var plan in userPlans)
            {
                Console.WriteLine(plan.Value);
            }
        }
    }
}
