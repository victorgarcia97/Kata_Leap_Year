namespace KataLeapYear.Tests
{
    public class YearTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsLeapYear1600()
        {
            var year = new Year(1600);

            Assert.True(year.IsLeap());
        }
    }
}