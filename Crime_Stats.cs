using System;

namespace CrimeAnalyzer {
    public class CrimeStats
    {
        public int Year;
        public int murder;
        public int rape;
        public int propertyCrime;
        public int population;
        public int violentCrime;
        public int burglary;
        public int theft;
        public int aggravatedAssault;
        public int motortheft;
        public int robbery;

        public CrimeStats(int year, int population, int violentCrime, int murder, int rape, int robbery, int aggravatedAssault, int propertyCrime, int burglary, int theft, int motortheft)
        {
            Year = year;

        }
    }
}