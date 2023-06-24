using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{
    internal class RegistrationMenu
    {
        internal static void RegistryOfNewUser()
        {
            bool registrationComplete = false;
            string? userLogin = "";
            string? userPassword = "";

            int loginLength = 5;
            int passwordLength = 10;

            DataSaving data = new DataSaving();

            while (userLogin!.Length < loginLength)
            {
                Console.WriteLine($"Длинна нового логина должна быть не менее {loginLength} символов." +
                    $" Введите ваш новый логин: ");

                userLogin = Console.ReadLine();

                if (userLogin == null || userLogin!.Length < loginLength)
                {
                    Console.WriteLine("Ошибка! Новый логин введен не верно.");
                }
            }

            while (userPassword!.Length < passwordLength)
            {
                Console.WriteLine($"Длинна нового пароля должна быть не менее {passwordLength} символов." +
                    $" Введите ваш новый пароль:");

                userPassword = Console.ReadLine();
                if (userPassword == null || userPassword!.Length < passwordLength)
                {
                    Console.WriteLine("Ошибка! Новый пароль введен не верно.");
                }
            }

            if (userPassword != null & userPassword!.Length >= passwordLength)
            {
                data.UserLoginAndPasswordSaving(userLogin, userPassword);

                registrationComplete = true;
            }
            else
            {
                BugReportSending(userLogin, userPassword);

                registrationComplete = false;
            }
        }

        private static void BugReportSending(string userLogin, string userPassword)
        {
            ErrorReports reports = new ErrorReports();

            string[,] report = new string[1, 3] { { "Ошибка меню регистрации пользователя", userLogin, userPassword } };

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры регистрации. Данные об ошибке были направлены в технический отдел.");
        }
    }
}
