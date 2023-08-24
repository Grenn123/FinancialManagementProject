using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinancialManagementProject
{
    public class PlanCreationMenu
    {
        internal string columnName;

        const int nameOfPlanLenght = 1;

        public void PlanCreation(string currentLogin)
        {
            string? answer;

            if (currentLogin != null || currentLogin != string.Empty)
            {
                Console.WriteLine("Хотите создать новый план?");
                answer = Console.ReadLine();

                if (answer!.ToLower().Contains('д'))
                {
                    do
                    {
                        Console.WriteLine($"Длинна названия нового плана должна быть не менее {nameOfPlanLenght} символов." +
                                                   $" Введите название вашего нового плана: ");

                        columnName = Console.ReadLine();

                        if (columnName == null || columnName == string.Empty || columnName!.Length < nameOfPlanLenght)
                        {
                            Console.WriteLine("Ошибка! Название нового плана введено не верно. ");

                            Console.WriteLine("Нажмите любую клавишу чтобы попытаться снова.");
                            Console.ReadKey();

                            continue;
                        }
                    } while (columnName!.Length < nameOfPlanLenght);

                    Console.WriteLine($"Поздравляю {currentLogin}, " +
                        $"вы создали план с названием {columnName}");
                }
            }
            else
            {
                BugReportSending();
            }
        }

        private void BugReportSending()
        {
            ErrorReports reports = new ErrorReports();

            string report = "Ошибка сохранения нового плана пользователя - имя пользователя пусто.";

            reports.SendingErrorReport(report);

            Console.WriteLine("Сбой процедуры создания нового плана. " +
                "Данные об ошибке были направлены в технический отдел.");
        }
    }
}
