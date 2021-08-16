using Calabonga.Contracts;
using GreenPipes;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Calabonga.Module1.Web.MassTransit
{
    // вместо интерфейса можно использовать классы
    /// <summary>
    /// Потребитель в цепи RabbitMQ
    /// </summary>
    public class ApplicationUserCreatedConsumer : IConsumer<IApplicationUserCreated>
    {
        private readonly ILogger<ApplicationUserCreatedConsumer> _logger;

        public ApplicationUserCreatedConsumer(ILogger<ApplicationUserCreatedConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<IApplicationUserCreated> context)
        {
            // сюда помещается логика обработки полученного сообщения
            // из RabbitMQ (например запись в базу данных)
            _logger.LogInformation("Success");
            return Task.CompletedTask;
        }
    }
}
