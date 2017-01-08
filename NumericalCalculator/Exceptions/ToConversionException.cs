using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class ToConversionException : Exception
    {
        public ToConversionException()
        {
        }

        public ToConversionException(string message) : base(message)
        {
        }

        public ToConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ToConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}