using System;
using System.Runtime.Serialization;

namespace PMC_Optymalizer.MathMedia
{
    [Serializable]
    internal class WrongSizeOfTableToInitiateMatrixException : Exception
    {
        public WrongSizeOfTableToInitiateMatrixException()
        {
        }

        public WrongSizeOfTableToInitiateMatrixException(string message) : base(message)
        {
        }

        public WrongSizeOfTableToInitiateMatrixException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongSizeOfTableToInitiateMatrixException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}