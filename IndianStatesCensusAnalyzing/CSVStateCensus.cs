using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStatesCensusAnalyzing
{
    class CSVStateCensus
    {
        public int NumberOfRecords(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.File_NOT_FOUND, "No file found in given path.");
            }
            if(filePath.Split(".")[1] != "csv")
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NOT_CSV, "Passed a non CSV format file type");
            }
            using (StreamReader reader = File.OpenText(filePath))
            {
                int count = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Split(",").Length > 1)
                    {
                        count++;
                    }
                    else
                    {
                        throw new CustomExceptions(CustomExceptions.ExceptionType.NOT_CORRECT_DELIMITER, "Delimiter is other than comma.");
                    }
                    if (count == 1 && line.Split(",").Length != 4)
                    {
                        throw new CustomExceptions(CustomExceptions.ExceptionType.WRONG_HEADER, "File has incorrect header.");
                    }
                }
                if (count - 1 < 0)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NO_DATA, "The CSV file has no data.");
                }
                return (count - 1);
            }
        }
    }
}
