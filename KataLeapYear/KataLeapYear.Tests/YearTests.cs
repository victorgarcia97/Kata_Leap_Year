using Newtonsoft.Json.Linq;

namespace KataLeapYear.Tests
{
    public class YearTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        public void IsLeapYearWhenDivisibleBy400(int value)
        {
            var year = new Year(value);

            Assert.True(year.IsLeap());
        }

        [Theory]
        [TestCase(1996)]
        [TestCase(2004)]
        [TestCase(2012)]
        public void IsLeapYearWhenDivisibleBy4(int value)
        {
            var year = new Year(value);

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