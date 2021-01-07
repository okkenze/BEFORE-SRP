using System;

namespace BEFORESRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            var formatedResult = generator.GenerateReportASString();

            Console.WriteLine();
            Console.WriteLine(formatedResult);
            Console.ReadLine();
        }
    }
}
