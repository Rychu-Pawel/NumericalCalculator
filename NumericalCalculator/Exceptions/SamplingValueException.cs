using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class SamplingValueException : Exception
    {
        public SamplingValueException()
        {
        }

        public SamplingValueException(string message) : base(message)
        {
        }

        public SamplingValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SamplingValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}