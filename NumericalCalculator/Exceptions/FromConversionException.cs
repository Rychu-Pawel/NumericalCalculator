using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class FromConversionException : Exception
    {
        public FromConversionException()
        {
        }

        public FromConversionException(string message) : base(message)
        {
        }

        public FromConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FromConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}