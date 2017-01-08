using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class xFromException : Exception
    {
        public xFromException()
        {
        }

        public xFromException(string message) : base(message)
        {
        }

        public xFromException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected xFromException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}