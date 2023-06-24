using FinancialManagementProject;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementProject
{
    internal class Program
    {


        static void Main(string[] args)
        {
            bool accessIsAllowed = false;

            Console.WriteLine($"Добрый день.\n");

            //Запуск верификации или регистрации
            VerificationOrRegistration(accessIsAllowed);

            //Открытие списка всех имеющихся у пользователя планов

            if (DataSaving.quantityOfPlans == 0)
            {
                PlanCreationMenu.PlanCreation(DataSaving.userLogin);
            }
            else
            {
                //Открывает меню управления планами
            }
        }

        //Получение данных
        private static void VerificationOrRegistration(bool accessIsAllowed)
        {
            Console.WriteLine("У вас уже есть учетная запись? Ответьте да или нет");

            string? answer = Console.ReadLine();

            if (answer!.ToLower().Contains('д'))
            {
                //Тут будет запуск загрузки данных из файла


                VerificationMenu.StartVerification(out accessIsAllowed);
            }
            else
            {
                RegistrationMenu.RegistryOfNewUser();
            }
        }
    }
}
