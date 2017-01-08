using System;
using System.Runtime.Serialization;

namespace NumericalCalculator.Exceptions
{
    [Serializable]
    internal class XFromIsGreaterThenXToException : Exception
    {
        public XFromIsGreaterThenXToException()
        {
        }

        public XFromIsGreaterThenXToException(string message) : base(message)
        {
        }

        public XFromIsGreaterThenXToException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected XFromIsGreaterThenXToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}