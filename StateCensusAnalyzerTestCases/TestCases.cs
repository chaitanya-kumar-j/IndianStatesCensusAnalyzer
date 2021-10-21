using IndianStatesCensusAnalyzing;
using NUnit.Framework;

namespace StateCensusAnalyzerTestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // Test 1.1
        [Test]
        public void GivenStateCensusDataFileWithCorrectNumberOfRecords_WhenIsNumberOfRecordsMatched_ThenShouldReturnTrue()
        {
            const string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\StateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
            Assert.AreEqual(true, result);
        }
        // Test 1.2
        [Test]
        public void GivenStateCensusDataFileWithWrongPath_WhenIsNumberOfRecordsMatched_ThenShouldReturn()
        {
            string expectedMessage = "No file found in given path.";
            const string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\StateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.3
        [Test]
        public void GivenStateCensusDataFileWithWrongTypeOfFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "Passed a non CSV format file type";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongTypeStateCensusData.txt";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.4
        [Test]
        public void GivenStateCensusDataFileWithWrongDelimiterInCSVFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "Delimiter is other than comma.";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongDelimiterStateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.5
        [Test]
        public void GivenStateCensusDataFileWithWrongHeaderInCSVFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "File has incorrect header.";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongHeaderStateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        // Test 2.1
        [Test]
        public void GivenStateCodeFileWithCorrectNumberOfRecords_WhenIsNumberOfRecordsMatched_ThenShouldReturnTrue()
        {
            const string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\StateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
            Assert.AreEqual(true, result);
        }
        // Test 1.2
        [Test]
        public void GivenStateCodeFileWithWrongPath_WhenIsNumberOfRecordsMatched_ThenShouldReturn()
        {
            string expectedMessage = "No file found in given path.";
            const string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\StateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.3
        [Test]
        public void GivenStateCodeFileWithWrongTypeOfFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "Passed a non CSV format file type";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongTypeStateCensusData.txt";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.4
        [Test]
        public void GivenStateCodeFileWithWrongDelimiterInCSVFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "Delimiter is other than comma.";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongDelimiterStateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        // Test 1.5
        [Test]
        public void GivenStateCodeFileWithWrongHeaderInCSVFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string expectedMessage = "File has incorrect header.";
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongHeaderStateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            try
            {
                bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
                Assert.AreEqual(true, result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
    }
}