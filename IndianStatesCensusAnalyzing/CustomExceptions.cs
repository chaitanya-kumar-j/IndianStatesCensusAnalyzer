﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyzing
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            File_NOT_FOUND, NO_DATA, NOT_CSV, RECORDS_MISMATCH, NOT_CORRECT_DELIMITER, WRONG_HEADER
        }
        private readonly ExceptionType type;
        public CustomExceptions(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
