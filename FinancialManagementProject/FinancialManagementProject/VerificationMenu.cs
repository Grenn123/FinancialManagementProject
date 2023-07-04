using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagementProject;

namespace FinancialManagementProject
{
    internal class VerificationMenu : DataOperations
    {
        private static string stageOfVerification = null; //Поле для приема даннных логина или пароля
        private const int maxOfAttepts = 3;
        private static int availableAttempts = maxOfAttepts;
        private static VerificationStage verificationStage = VerificationStage.Login;

        internal bool verificationComplete;

        //Поля подбора формулировок
        private static string loginOrPasswordRequest = null;
        private static string inputCorrect = null;
        private static string inputError = null;
        private static string endOfAttempts = null;

        //Запус процедуры верификации
        internal void StartVerification()
        {
            while (verificationStage < VerificationStage.AccessIsAllowed)
            {
                InputCheck();
            }

            switch (verificationStage)
            {
                case VerificationStage.AccessIsAllowed:
                    verificationComplete = true;
                    break;

                case VerificationStage.AccessDenied:
                    verificationComplete = false;
                    break;
            }
        }

        //Процесс сравнения значений
        private void InputCheck()
        {
            string userInput;

            while (availableAttempts > 0)
            {
                SelectionOfWording();

                Console.WriteLine(loginOrPasswordRequest);
                userInput = Console.ReadLine();

                if (stageOfVerification == userInput)
                {
                    Console.WriteLine(inputCorrect);
                    availableAttempts = maxOfAttepts;

                    verificationStage++;
                    break;
                }
                else
                {
                    availableAttempts--;

                    if (availableAttempts > 0)
                    {
                        Console.WriteLine(inputError);
                    }
                }
            }

            if (availableAttempts <= 0)
            {
                Console.WriteLine(endOfAttempts);
                verificationStage = VerificationStage.AccessDenied;
            }
        }

        //Подбор формулировок
        private void SelectionOfWording()
        {
            switch (verificationStage)
            {
                case VerificationStage.Login:
                    loginOrPasswordRequest = "Введите ваш логин:";
                    stageOfVerification = DataOperations.UserLogin;
                    inputCorrect = $"Здравствуйте, {stageOfVerification}.";
                    inputError = $"Такого логина не существует. Осталось попыток {availableAttempts - 1}.";
                    endOfAttempts = "Такого логина не существует. Количество попыток исчерпано.";
                    break;

                case VerificationStage.Password:
                    loginOrPasswordRequest = "Введите ваш пароль:";
                    stageOfVerification = DataOperations.UserPassword;
                    inputCorrect = "Все данные верны. Добро пожаловать.";
                    inputError = $"Пароль не подходит. Осталось попыток {availableAttempts - 1}.";
                    endOfAttempts = "Ни один из введенных паролей не подходит. Количество попыток исчерпано.";
                    break;

                default:
                    Console.WriteLine("Что-то пошло  не так в подборе формулировок");
                    BugReportSending();
                    break;
            }
        }
        private void BugReportSending()
        {
            ErrorReports reports = new ErrorReports();

            string report = $"Ошибка меню регистрации пользователя, {DataOperations.UserLogin}";

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры регистрации. Данные об ошибке были направлены в технический отдел.");
        }
    }
}
