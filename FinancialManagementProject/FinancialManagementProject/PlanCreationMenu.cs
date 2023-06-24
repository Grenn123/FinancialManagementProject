using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProject
{
    internal class PlanCreationMenu
    {
        internal static void PlanCreation(string userLogin)
        {
            DataSaving data = new DataSaving();

            userLogin = DataSaving.userLogin;
            string? answer;

            if (userLogin != null)
            {
                Console.WriteLine("Хотите создать новый план?");
                answer = Console.ReadLine();

                Console.WriteLine("Введите название вашего нового плана:");
                string? nameOfPlan = Console.ReadLine();

                if (nameOfPlan != null)
                {
                    data.SavingNameOfNewPlan(nameOfPlan);
                }
                else
                {
                    Console.WriteLine("Название плана is null");
                }


                //////Тестировочный блок - впоследствии будет удален//////
                foreach (var pair in data.userPlans)
                {
                    Console.WriteLine($"План пользователя {pair.Key} называется {pair.Value}");
                }
                /////////////////////////////////////////////////////////

            }
            else
            {
                Console.WriteLine("Ошибка сохранения логина пользователя");
            }


        }
        private static void BugReportSending(string userLogin)
        {
            ErrorReports reports = new ErrorReports();

            string[,] report = new string[1, 2] { { "Ошибка сохранения логина пользователя", userLogin } };

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры создания нового плана. " +
                "Данные об ошибке были направлены в технический отдел.");
        }
    }
}
