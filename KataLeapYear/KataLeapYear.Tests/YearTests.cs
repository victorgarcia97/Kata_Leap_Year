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
        
        [Test]
        public void IsNotLeapYear2023()
        {
            var year = new Year(2023);

            Assert.False(year.IsLeap());
        }
    }
}