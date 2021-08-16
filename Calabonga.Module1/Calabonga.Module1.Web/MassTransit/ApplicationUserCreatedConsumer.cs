using Calabonga.Contracts;
using MassTransit;
using System.Threading.Tasks;

namespace Calabonga.Module1.Web.MassTransit
{
    // вместо интерфейса можно использовать классы
    public class ApplicationUserCreatedConsumer : IConsumer<IApplicationUserCreated>
    {
        public Task Consume(ConsumeContext<IApplicationUserCreated> context)
        {
            // сюда помещается логика обработки полученного сообщения
            // из RabbitMQ (например запись в базу данных)
            return Task.CompletedTask;
        }
    }
}
