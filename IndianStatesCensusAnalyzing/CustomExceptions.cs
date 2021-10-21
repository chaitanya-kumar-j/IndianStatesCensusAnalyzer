using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyzing
{
    class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            NO_DATA,NOT_CSV,RECORDS_MISMATCH,NOT_CORRECT_DELIMITER
        }
        private readonly ExceptionType type;
        public CustomExceptions(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
