using FinancialManagementProject;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementProject
{
    internal class Program
    {
        internal static bool accessIsAllowed;


        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день.");

            DataLoading();
        }

        //Получение данных
        private static void DataLoading()
        {
            DataSaving data = new DataSaving();

            StartVerification(data.userName, data.userPassword);
        }

        //Запуск процедуры верификации
        private static void StartVerification(string userName, string userPassword)
        {
            VerificationMenu verification = new VerificationMenu();

            verification.AccessVerification(userName, userPassword, out accessIsAllowed);

            if (accessIsAllowed)
            {
                Console.WriteLine("Ура! У вас получилось!");
            }
            else
            {
                Console.WriteLine("Доступ закрыт");
            }
        }
    }
}
