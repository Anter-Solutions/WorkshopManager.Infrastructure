using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Infrastructure.Exceptions
{
    public class NoAvailableConstructorException : Exception
    {
        public NoAvailableConstructorException()
        {
        }

        public NoAvailableConstructorException(string? message) : base(message)
        {
        }

        public NoAvailableConstructorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoAvailableConstructorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }


    }
}
