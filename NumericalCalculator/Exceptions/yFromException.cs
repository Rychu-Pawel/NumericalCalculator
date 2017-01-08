using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class yFromException : Exception
    {
        public yFromException()
        {
        }

        public yFromException(string message) : base(message)
        {
        }

        public yFromException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected yFromException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}