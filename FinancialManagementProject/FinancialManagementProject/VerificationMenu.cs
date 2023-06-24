using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagementProject;

namespace FinancialManagementProject
{
    internal class VerificationMenu
    {

        private static string stageOfVerification = ""; //Поле для приема даннных логина или пароля

        private static int availableAttempts = 3;       //Количество попыток на каждом этапе
        private static int verificationStage = 1;       //Номер процедуры: 1 - логин, 2 - пароль, 3 - доступ открыт, 4 - отказ


        //Поля подбора формулировок
        private static string loginOrPasswordRequest = "";
        private static string inputCorrect = "";
        private static string inputError = "";
        private static string endOfAttempts = "";
        private static bool accessCheck;

        //Запус процедуры верификации
        internal static bool StartVerification(out bool accessIsAllowed)
        {
            while (verificationStage < 3)
            {
                switch (verificationStage)
                {
                    case 1:
                        stageOfVerification = DataSaving.userLogin;
                        InputCheck(stageOfVerification);
                        break;

                    case 2:
                        stageOfVerification = DataSaving.userPassword;
                        InputCheck(stageOfVerification);
                        break;
                }
            }

            return verificationStage == 3
                            ? accessIsAllowed = true
                            : accessIsAllowed = false;
        }


        //Процесс сравнения значений
        private static int InputCheck(string stageOfVerification)
        {
            string? userInput = "";

            SelectionOfWording(stageOfVerification);

            while (availableAttempts > 0)
            {
                Console.WriteLine(loginOrPasswordRequest);
                userInput = Console.ReadLine();


                if (stageOfVerification == userInput)
                {
                    Console.WriteLine(inputCorrect);
                    availableAttempts = 3;

                    return verificationStage = verificationStage + 1;
                }
                else
                {
                    availableAttempts--;

                    if (availableAttempts > 0)
                    {
                        Console.WriteLine(inputError);
                    }

                    return verificationStage;
                }
            }

            if (availableAttempts <= 0)
            {
                Console.WriteLine(endOfAttempts);
                verificationStage = 4;
            }

            return verificationStage;
        }

        //Подбор формулировок
        private static void SelectionOfWording(string stageOfVerification)
        {
            switch (verificationStage)
            {
                case 1:
                    loginOrPasswordRequest = "Введите ваш логин:";
                    inputCorrect = $"Здравствуйте, {stageOfVerification}.";
                    inputError = $"Такого логина не существует. Осталось попыток {availableAttempts - 1}.";
                    endOfAttempts = "Такого логина не существует. Количество попыток исчерпано.";
                    break;

                case 2:
                    loginOrPasswordRequest = "Введите ваш пароль:";
                    inputCorrect = "Все данные верны. Добро пожаловать.";
                    inputError = $"Пароль не подходит. Осталось попыток {availableAttempts - 1}.";
                    endOfAttempts = "Ни один из введенных паролей не подходит. Количество попыток исчерпано.";
                    break;

                default:
                    Console.WriteLine("Что-то пошло  не так в подборе фоормулировок");
                    break;
            }
        }
    }
}
