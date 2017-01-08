using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class ToIIConversionException : Exception
    {
        public ToIIConversionException()
        {
        }

        public ToIIConversionException(string message) : base(message)
        {
        }

        public ToIIConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ToIIConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}