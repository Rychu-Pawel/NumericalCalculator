using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class PointConversionException : Exception
    {
        public PointConversionException()
        {
        }

        public PointConversionException(string message) : base(message)
        {
        }

        public PointConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PointConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}