using System;
using System.Linq;
using System.Collections.Generic;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) //if there isn't two arg inputs, it will exit the program.
            {
                Console.WriteLine("Crime Analyzer <crime_csv_file_path> <report_file path>");
                Environment.Exit(1);
            }
        }
    }
}
