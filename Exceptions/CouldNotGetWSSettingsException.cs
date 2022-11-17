using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Infrastructure.Exceptions
{
    public class CouldNotGetWSSettingsException : Exception
    {
        public CouldNotGetWSSettingsException()
        {
        }

        public CouldNotGetWSSettingsException(string? message) : base(message)
        {
        }

        public CouldNotGetWSSettingsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CouldNotGetWSSettingsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
