using System;
using System.Globalization;

namespace Tournament.Utilities.Converters
{
    public static class DataTimeConverter
    {
        private static string _format = "yyyyMMddHHmmss";

        public static string GetString(DateTime? dateTime)
        {
            var stringDate = string.Empty;
            if (dateTime != null)
                stringDate = ((DateTime)dateTime).ToString(_format);
            return stringDate;
        }

        public static DateTime? GetDateTime(string dateTimeString)
        {
            DateTime? dateTime = null;
            if (!string.IsNullOrEmpty(dateTimeString))
                try
                {
                    dateTime = DateTime.ParseExact(dateTimeString, _format, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    throw new Exception("Incorrect data format.");
                }
            return dateTime;
        }
    }
}
