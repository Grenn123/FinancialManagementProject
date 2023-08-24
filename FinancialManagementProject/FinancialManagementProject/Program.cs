using FinancialManagementProject;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace FinancialManagementProject
{
    internal class Program
    {
        internal static string userID;

        internal static DataOperations dataOperations = new DataOperations();
        internal static VerificationMenu verificationMenu = new VerificationMenu();
        internal static RegistrationMenu registrationMenu = new RegistrationMenu();
        internal static PlanCreationMenu planCreationMenu = new PlanCreationMenu();

        private static bool accessIsAllowed;
        internal static string currentLogin;

        static void Main(string[] args)
        {
            //Form1 mmm = new Form1();

            Console.WriteLine($"Добрый день.\n");

            //Запуск верификации или регистрации
            VerificationOrRegistration();


            if (accessIsAllowed)
            {
                if (dataOperations.QuantityOfPlans == 0)
                {    
                    planCreationMenu.PlanCreation(currentLogin);

                    dataOperations.SavingNameOfNewPlan();
                }
                else
                {
                    //Открывает меню управления планами
                }
            }
            else
            {
                Console.WriteLine("Доступ запрещен из Main");
            }
        }

        //Получение данных
        public static void VerificationOrRegistration()
        {
            Console.WriteLine("У вас уже есть учетная запись? Ответьте да или нет");

            string? answer = Console.ReadLine();

            if (answer!.ToLower().Contains('д'))
            {
                dataOperations.DataLoading();

                verificationMenu.StartVerification();

                accessIsAllowed = verificationMenu.verificationComplete;
            }
            else
            {
                registrationMenu.RegistryOfNewUser();

                accessIsAllowed = registrationMenu.registrationComplete;

                if (accessIsAllowed)
                {
                    dataOperations.UserLoginAndPasswordSaving();
                }
            }
        }
    }
}
