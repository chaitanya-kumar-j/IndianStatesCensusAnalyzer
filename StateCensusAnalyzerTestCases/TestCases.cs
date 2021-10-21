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

        [Test]
        public void GivenCorrectNumberOfRecords_WhenIsNumberOfRecordsMatched_ThenShouldReturnTrue()
        {
            const string STATE_CENSUS_DATA_FILE_PATH = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\StateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            bool result = censusAnalyzer.IsNumberOfRecordsMatched(STATE_CENSUS_DATA_FILE_PATH, 29);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenWrongTypeOfFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\TestTextFile.txt";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
            Assert.AreEqual(false, result);
        }
        [Test]
        public void GivenWrongDelimiterInCSVFile_WhenIsNumberOfRecordsMatched_ThenShouldReturnFalse()
        {
            string filePath = @"G:\BridgeLabz\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzing\DataFiles\WrongTypeStateCensusData.csv";
            StateCensusAnalyzer censusAnalyzer = new StateCensusAnalyzer();
            bool result = censusAnalyzer.IsNumberOfRecordsMatched(filePath, 29);
            Assert.AreEqual(false, result);
        }
    }
}