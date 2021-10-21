using System;

namespace IndianStatesCensusAnalyzing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter the program number:\n" +
                    "1. Loding State Census data file, 2. Loading State Code file");
                StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
                const string STATE_CENSUS_DATA_FILE_PATH = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\StateCensusData.csv";
                const string STATE_CODE_FILE_PATH = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\StateCode.csv";
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        Console.WriteLine(censusAnalyzer.IsNumberOfRecordsMatched(STATE_CENSUS_DATA_FILE_PATH, 29));
                        break;
                    case 2:
                        Console.WriteLine(censusAnalyzer.IsNumberOfRecordsMatched(STATE_CODE_FILE_PATH, 29));
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
