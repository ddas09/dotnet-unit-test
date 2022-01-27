using Moq;
using NUnit.Framework;

[TestFixture]
public class SortRecordTest
{
    [Test]
    public void GetSortedRecordTest()
    {
        int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] testData = { 9, 1, 5, 7, 6, 4, 2, 8, 3 };
        
        Mock<GetRecord> getRecord = new Mock<GetRecord>();
        getRecord.Setup(x => x.GetDataFromDB()).Returns(testData);
        SortRecord sortRecord = new SortRecord();

        int[] sortedResult = sortRecord.GetSortedRecord(getRecord.Object);

        Assert.AreEqual(expectedResult, sortedResult);
    }
}