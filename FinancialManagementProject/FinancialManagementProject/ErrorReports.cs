using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementProject
{
    internal class ErrorReports
    {
        private List<string> errors = new List<string>();

        internal void SendingErrorReport(string message)
        {
            errors.Add(message);
        }

        internal void PrintErrorsReport()
        {
            Console.WriteLine("Хотите посмотреть отчет об ошибке? Ответьте да или нет");

            string? answer = Console.ReadLine();

            if (answer!.ToLower().Contains('д'))
            {
                foreach (string line in errors)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
