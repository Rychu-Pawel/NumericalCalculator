using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class CutoffValueException : Exception
    {
        public CutoffValueException()
        {
        }

        public CutoffValueException(string message) : base(message)
        {
        }

        public CutoffValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CutoffValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}