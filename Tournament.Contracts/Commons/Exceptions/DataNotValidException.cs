using System;

namespace Tournament.Contracts.Commons.Exceptions
{
    public class DataNotValidException : Exception
    {

        public DataNotValidException(string data) : base(data)
        {

        }
    }
}
