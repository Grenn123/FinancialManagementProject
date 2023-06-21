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

        internal void SendingErrorReport(string[,] message)
        {
            //Зарисовка на будущее.
            int numberOfLines = 1;
            int numberOfColumns = 3;

            string[,] unprocessedReports = new string[numberOfLines, numberOfColumns];
            unprocessedReports = message;

            Console.WriteLine("Хотите посмотреть отчет об ошибке? Ответьте да или нет");

            string? answer = Console.ReadLine();

            if (answer!.ToLower().Contains('д'))
            {
                foreach (string line in unprocessedReports)
                {
                    Console.WriteLine(line);
                }
                
            }
        }
    }
}
