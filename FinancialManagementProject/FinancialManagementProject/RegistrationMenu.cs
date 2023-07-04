using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{
    internal class RegistrationMenu : DataOperations
    {
        const int loginLength = 5;
        const int passwordLength = 10;
        internal bool registrationComplete = false;

        internal static string? registrationUserLogin;
        internal static string? registrationUserPassword;


        internal void RegistryOfNewUser()
        {
            do
            {
                Console.WriteLine($"Длинна нового логина должна быть не менее {loginLength} символов." +
                    $" Введите ваш новый логин: ");

                registrationUserLogin = Console.ReadLine();

                if (registrationUserLogin == null || registrationUserLogin!.Length < loginLength)
                {
                    Console.WriteLine("Ошибка! Новый логин введен не верно.");
                }
            } while (registrationUserLogin!.Length < loginLength);

            do
            {
                Console.WriteLine($"Длинна нового пароля должна быть не менее {passwordLength} символов." +
                    $" Введите ваш новый пароль:");

                registrationUserPassword = Console.ReadLine();
                if (registrationUserPassword == null || registrationUserPassword!.Length < passwordLength)
                {
                    Console.WriteLine("Ошибка! Новый пароль введен не верно.");
                }
            } while (registrationUserPassword!.Length < passwordLength);


            if (registrationUserPassword != null & registrationUserPassword!.Length >= passwordLength)
            {
                registrationComplete = true;
                return;
            }
            else
            {
                registrationComplete = false;
                BugReportSending(registrationUserLogin, registrationUserPassword);
            }
        }

        private void BugReportSending(string userLogin, string userPassword)
        {
            ErrorReports reports = new ErrorReports();

            string report = $"Ошибка меню регистрации пользователя, {userLogin}";

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры регистрации. Данные об ошибке были направлены в технический отдел.");
        }
    }
}
