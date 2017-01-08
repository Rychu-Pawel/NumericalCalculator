using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class FunctionNullReferenceException : Exception
    {
        public FunctionNullReferenceException()
        {
        }

        public FunctionNullReferenceException(string message) : base(message)
        {
        }

        public FunctionNullReferenceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FunctionNullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}