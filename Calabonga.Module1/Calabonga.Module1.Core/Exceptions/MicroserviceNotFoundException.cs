using System;

namespace Calabonga.Module1.Core.Exceptions
{
    /// <summary>
    /// Represent Price Point Exception
    /// </summary>
    public class MicroserviceNotFoundException : Exception
    {
        public MicroserviceNotFoundException() : base(AppData.Exceptions.NotFoundException)
        {

        }

        public MicroserviceNotFoundException(string message) : base(message)
        {

        }

        public MicroserviceNotFoundException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
