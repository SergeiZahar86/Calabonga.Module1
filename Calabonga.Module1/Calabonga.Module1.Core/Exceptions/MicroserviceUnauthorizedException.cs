using System;

namespace Calabonga.Module1.Core.Exceptions
{
    /// <summary>
    /// Represent Price Point Exception
    /// </summary>
    public class MicroserviceUnauthorizedException : Exception
    {
        public MicroserviceUnauthorizedException() : base(AppData.Exceptions.UnauthorizedException)
        {

        }

        public MicroserviceUnauthorizedException(string message) : base(message)
        {

        }

        public MicroserviceUnauthorizedException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
