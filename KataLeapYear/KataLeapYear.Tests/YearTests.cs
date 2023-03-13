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

        [Test]
        public void IsLeapYear1996()
        {
            var year = new Year(1996);

            Assert.True(year.IsLeap());
        }

        [Test]
        public void IsLeapYear2004()
        {
            var year = new Year(2004);

            Assert.True(year.IsLeap());
        }

        [Test]
        public void IsLeapYear2012()
        {
            var year = new Year(2012);

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