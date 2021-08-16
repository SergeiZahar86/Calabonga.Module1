using Calabonga.Contracts;
using GreenPipes;
using MassTransit;
using MassTransit.ConsumeConfigurators;
using MassTransit.Definition;

namespace Calabonga.Module1.Web.MassTransit
{
    /// <summary>
    /// Этот класс нужен чтобы можно было зарегистрировать получателя 
    /// ApplicationUserCreatedConsumer с конструктором
    /// </summary>
    public class ApplicationUserCreatedConsumerDefinition
        : ConsumerDefinition<ApplicationUserCreatedConsumer>
    {
        public ApplicationUserCreatedConsumerDefinition()
        {
            EndpointName = Constants.NotificationQueueNameConfiguration;
        }

        /// <summary>
        /// Настройки конфигурации.
        /// Вызывается, когда потребитель настроен на конечной точке. Только конфигурация
        /// относится к этому потребителю и не распространяется на конечную точку.
        /// </summary>
        /// <param name="endpointConfigurator"></param>
        /// <param name="consumerConfigurator"></param>
        protected override void ConfigureConsumer(
            IReceiveEndpointConfigurator endpointConfigurator,
            IConsumerConfigurator<ApplicationUserCreatedConsumer> consumerConfigurator)
        {
            // настройка интервала
            //endpointConfigurator.UseRetry(x => x.Intervals(100, 500, 1000));
        }
    }
}
