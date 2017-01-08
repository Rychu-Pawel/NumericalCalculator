using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class xToException : Exception
    {
        public xToException()
        {
        }

        public xToException(string message) : base(message)
        {
        }

        public xToException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected xToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}