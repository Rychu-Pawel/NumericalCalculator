using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class YFromIsGreaterThenYToException : Exception
    {
        public YFromIsGreaterThenYToException()
        {
        }

        public YFromIsGreaterThenYToException(string message) : base(message)
        {
        }

        public YFromIsGreaterThenYToException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YFromIsGreaterThenYToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}