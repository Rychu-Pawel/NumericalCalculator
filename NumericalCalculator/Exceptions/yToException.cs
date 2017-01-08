using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class yToException : Exception
    {
        public yToException()
        {
        }

        public yToException(string message) : base(message)
        {
        }

        public yToException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected yToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}