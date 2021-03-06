using System;

namespace Calabonga.Module1.Core.Exceptions
{
    /// <summary>
    /// Represent Price Point Exception
    /// </summary>
    public class MicroserviceEntityValidationException : Exception
    {
        public MicroserviceEntityValidationException() : base(AppData.Exceptions.EntityValidationException)
        {

        }

        public MicroserviceEntityValidationException(string message) : base(message)
        {

        }

        public MicroserviceEntityValidationException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
