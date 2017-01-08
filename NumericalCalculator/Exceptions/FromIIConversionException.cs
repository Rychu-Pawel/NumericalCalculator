using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class FromIIConversionException : Exception
    {
        public FromIIConversionException()
        {
        }

        public FromIIConversionException(string message) : base(message)
        {
        }

        public FromIIConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FromIIConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}