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
        [TestCase(1200)]
        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        [TestCase(2800)]
        public void IsLeapYearWhenDivisibleBy400(int value)
        {
            var year = new Year(value);

            Assert.True(year.IsLeap());
        }

        [Theory]
        [TestCase(1992)]
        [TestCase(1996)]
        [TestCase(2004)]
        [TestCase(2012)]
        [TestCase(2016)]
        [TestCase(2020)]
        public void IsLeapYearWhenDivisibleBy4(int value)
        {
            var year = new Year(value);

            Assert.True(year.IsLeap());
        }

        [Theory]
        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2019)]
        [TestCase(2021)]
        [TestCase(2022)]
        [TestCase(2023)]
        public void IsNotLeapYearWhenItsNotDivisibleBy4(int value)
        {
            var year = new Year(value);

            Assert.False(year.IsLeap());
        }
        
        [Theory]
        [TestCase(1100)]
        [TestCase(1300)]
        [TestCase(1500)]
        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        public void IsNotLeapYearWhenItsDivisibleBy100ButNotBy400(int value)
        {
            var year = new Year(value);

            Assert.False(year.IsLeap());
        }
    }
}