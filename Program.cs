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
            // always start at zero, then one and so on.
            string dataFilePath = args[0];
            string reportFilePath = args[1];

            List<CrimeStats> crimeStatsList = null;
        }
    }
}
