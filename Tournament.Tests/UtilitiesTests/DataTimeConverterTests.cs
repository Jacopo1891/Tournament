using System;
using Tournament.Utilities.Converters;
using Xunit;

namespace Tournament.Tests.UtilitiesTests
{
    public class DataTimeConverterTests
    {
        [Fact]
        public void GetStringFromDateTime_Ok()
        {
            var dateTime = new DateTime(2020, 08, 09, 17, 00, 00, 0);
            var dateResult = DataTimeConverter.GetString(dateTime);
            Assert.Equal("20200809170000", dateResult);
        }

        [Fact]
        public void GetStringFromDateTime_Ok_Null()
        {
            DateTime? dateTime = null;
            var dateResult = DataTimeConverter.GetString(dateTime);
            Assert.Equal(string.Empty, dateResult);
        }

        [Fact]
        public void GetDateTimeFromString_Ok()
        {
            var dateTime = new DateTime(2020, 08, 09, 17, 00, 00, 0);
            var dateResult = DataTimeConverter.GetDateTime("20200809170000");
            Assert.Equal(dateTime, dateResult);
        }

        [Fact]
        public void GetDateTimeFromString_Ok_Null()
        {
            DateTime? dateTime = null;
            var dateResult = DataTimeConverter.GetDateTime(string.Empty);
            Assert.Equal(dateTime, dateResult);
        }

        [Fact]
        public void GetDateTimeFromString_IncorrectFormat_Exception()
        {
            var exception = Assert.Throws<Exception>(() => DataTimeConverter.GetDateTime("abc"));
            Assert.Equal("Incorrect data format.", exception.Message);
        }
    }
}
