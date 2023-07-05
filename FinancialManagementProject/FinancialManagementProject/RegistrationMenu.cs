using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{
    internal class RegistrationMenu
    {
        const int loginLength = 5;
        const int passwordLength = 10;
        internal bool registrationComplete;

        internal static string? registrationUserLogin;
        internal static string? registrationUserPassword;


        internal void RegistryOfNewUser()
        {
            do
            {
                Console.WriteLine($"Длинна нового логина должна быть не менее {loginLength} символов." +
                    $" Введите ваш новый логин: ");

                registrationUserLogin = Console.ReadLine();

                if (registrationUserLogin == null || registrationUserLogin == string.Empty 
                    || registrationUserLogin!.Length < loginLength)
                {
                    Console.WriteLine("Ошибка! Новый логин введен не верно.");
                }
            } while (registrationUserLogin!.Length < loginLength);

            do
            {
                Console.WriteLine($"Длинна нового пароля должна быть не менее {passwordLength} символов." +
                    $" Введите ваш новый пароль:");

                registrationUserPassword = Console.ReadLine();
                if (registrationUserPassword == null || registrationUserLogin == string.Empty 
                    || registrationUserPassword!.Length < passwordLength)
                {
                    Console.WriteLine("Ошибка! Новый пароль введен не верно.");
                }
            } while (registrationUserPassword!.Length < passwordLength);


            if (registrationUserPassword != null & registrationUserLogin != string.Empty 
                & registrationUserPassword!.Length >= passwordLength)
            {
                registrationComplete = true;
                Program.currentLogin = registrationUserLogin;
                return;
            }
            else
            {
                registrationComplete = false;
                BugReportSending(registrationUserLogin);
            }
        }

        private void BugReportSending(string userLogin)
        {
            ErrorReports reports = new ErrorReports();

            string report = $"Ошибка меню регистрации пользователя, {userLogin}";

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры регистрации. Данные об ошибке были направлены в технический отдел.");
        }
    }
}
