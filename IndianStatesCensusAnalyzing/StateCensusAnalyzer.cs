using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStatesCensusAnalyzing
{
    public class StateCensusAnalyzer
    {
        public bool IsNumberOfRecordsMatched(string filePath, int records)
        {
            try
            {
                CSVStateCensus censusAnalyzer = new CSVStateCensus();
                if (censusAnalyzer.NumberOfRecords(filePath) == records)
                {
                    return true;
                }
                return false;
            }
            catch (CustomExceptions ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
