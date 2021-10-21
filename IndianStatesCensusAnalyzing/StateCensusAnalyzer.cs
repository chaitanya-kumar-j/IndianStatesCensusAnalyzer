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
                throw new CustomExceptions(CustomExceptions.ExceptionType.RECORDS_MISMATCH, "Number of records are not matching.");
            }
            catch (CustomExceptions ex)
            {
                throw ex;
            }
        }
    }
}
